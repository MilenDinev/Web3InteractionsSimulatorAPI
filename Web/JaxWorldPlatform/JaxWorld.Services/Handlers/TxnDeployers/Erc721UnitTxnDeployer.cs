namespace JaxWorld.Services.Handlers.TxnDeployers
{
    using Constants;
    using Exceptions;
    using Interfaces;
    using Interfaces.ITxnManagers;
    using Data.Entities;
    using Models.Requests.BlockchainRequests.UnitModels;
    using Models.Responses.BlockchainResponses.ProfileUnitModels;

    public class Erc721UnitTxnDeployer
    {

        private readonly IErc721UnitTxnDeployerManager erc721UnitTxnDeployerManager;
        private readonly ITxnDeployerValidator txnDeployerValidator;

        public Erc721UnitTxnDeployer(IErc721UnitTxnDeployerManager erc721UnitTxnDeployerManager, ITxnDeployerValidator txnDeployerValidator)
        {
            this.erc721UnitTxnDeployerManager = erc721UnitTxnDeployerManager;
            this.txnDeployerValidator = txnDeployerValidator;
        }

        public async Task<CreatedErc721aUnitModel> MintErc721aUnitTxnAsync(CreateErc721aUnitModel createErc721aUnitModel, User user)
        {
            var networkId = await this.erc721UnitTxnDeployerManager.GetUnitNetworkIdAsync(createErc721aUnitModel.ProfileId);

            var gasUsed = GasUsedParams.Erc721aMintGas;

            var createTransactionModel = await this.erc721UnitTxnDeployerManager.GetCreateTxnModelAsync(TransactionStates.Pending, 
                TxnActions.Mint,
                networkId, 
                user.Id,
                user.WalletId,
                gasUsed);

            var tokenGas = gasUsed * GasUsedParams.MintMultiplierGas;

            var contract = await this.erc721UnitTxnDeployerManager.GetProfileContractAsync(user.Wallet, createErc721aUnitModel.ProfileId);

            var isValidWallet = await this.txnDeployerValidator.ValidateWalletAsync(user.Wallet, contract.Address, tokenGas);

            var transaction = await this.erc721UnitTxnDeployerManager.CreateTxnAsync(createTransactionModel, contract.Id);

            if (isValidWallet)
            {
                var createdErc721aUnitModel = await this.erc721UnitTxnDeployerManager.CreateErc721UnitAsync(createErc721aUnitModel, user);

                user.Wallet.Balance -= tokenGas;
                await this.erc721UnitTxnDeployerManager.UpdateTxnStateAsync(transaction, TransactionStates.Confirmed, transaction.CreatorId);

                return createdErc721aUnitModel;
            }

            await this.erc721UnitTxnDeployerManager.UpdateTxnStateAsync(transaction, TransactionStates.Rejected, user.Id);
            throw new ResourceNotFoundException(string.Format(ErrorMessages.OperationExecutionRejected));

        }
    }
}
