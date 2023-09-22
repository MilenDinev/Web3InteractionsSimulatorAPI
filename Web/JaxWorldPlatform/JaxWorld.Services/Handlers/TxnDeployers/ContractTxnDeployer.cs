namespace JaxWorld.Services.Handlers.TxnDeployers
{
    using Constants;
    using Exceptions;
    using Interfaces;
    using Interfaces.ITxnManagers;
    using Data.Entities;
    using Models.Requests.BlockchainRequests.ContractModels;
    using Models.Responses.BlockchainResponses.ContractModels;

    public class ContractTxnDeployer : IContractTxnDeployer
    {

        private readonly ITxnDeployerValidator txnDeployerValidator;
        private readonly IContractTxnDeployerManager contractTxnDeployerManager;

        public ContractTxnDeployer(IContractTxnDeployerManager contractTxnDeployerManager,
            ITxnDeployerValidator txnDeployerValidator)
        {
            this.contractTxnDeployerManager = contractTxnDeployerManager;
            this.txnDeployerValidator = txnDeployerValidator;
        }

        public async Task<CreatedContractModel> DeployContractTxnAsync(CreateContractModel createContractModel, User user)
        {
            var gasUsed = GasUsedParams.ContractDeployGas;

            var createTransactionModel = await this.contractTxnDeployerManager.GetCreateTxnModelAsync(
                TransactionStates.Pending,
                TxnActions.Deploy,
                createContractModel.NetworkId,
                user.Id,
                user.WalletId,
                gasUsed);

            var contractAddress = DeployerContract.Address;
            var tokenGas = gasUsed * GasUsedParams.DeployMultiplierGas;

            var isValidWallet = await this.txnDeployerValidator.ValidateWalletAsync(user.Wallet, contractAddress, tokenGas);

            var transaction = await this.contractTxnDeployerManager.CreateTxnAsync(createTransactionModel);

            if (isValidWallet)
            {
                var createdContractModel = await this.contractTxnDeployerManager.CreateContractAsync(createContractModel, user);

                transaction.TargetId = createdContractModel.Id;
                user.Wallet.Balance -= tokenGas;
                await contractTxnDeployerManager.UpdateTxnStateAsync(transaction, TransactionStates.Confirmed, user.Id);

                return createdContractModel;
            }

            await contractTxnDeployerManager.UpdateTxnStateAsync(transaction, TransactionStates.Rejected, user.Id);
            throw new ResourceNotFoundException(string.Format(ErrorMessages.OperationExecutionRejected));
        }
    }
}
