namespace JaxWorld.Services.Handlers.TxnDeployers
{
    using Constants;
    using Exceptions;
    using Interfaces;
    using Main.Interfaces;
    using Data.Entities;
    using Data.Entities.Wallets;
    using Models.Requests.BlockchainRequests.ContractModels;
    using Models.Responses.BlockchainResponses.ContractModels;

    public class ContractTxnDeployer : TransactionDeployer, IContractTxnDeployer
    {
        protected readonly IContractService contractService;

        public ContractTxnDeployer(IContractService contractService,
            IBlockService blockService,
            ITransactionService transactionService
            ) : base(blockService, transactionService)
        {
            this.contractService = contractService;
        }

        public async Task<CreatedContractModel> DeployContractTxnAsync(CreateContractModel createContractModel, User user)
        {
            var createTransactionModel = await GetCreateTxnModelAsync(
                TransactionStates.Pending,
                TxnActions.Deploy,
                createContractModel.NetworkId,
                user.Id,
                user.WalletId,
                GasUsedParams.ContractDeployGas);

            // Validate the wallet
            var isValidWallet = await ValidateWallet(user.Wallet);

            var transaction = await transactionService.CreateAsync(createTransactionModel);

            if (isValidWallet)
            {
                var createdContractModel = await contractService.CreateAsync(createContractModel, user);

                transaction.TargetId = createdContractModel.Id;
                await transactionService.UpdateStateAsync(transaction, TransactionStates.Confirmed, user.Id);

                return createdContractModel;
            }

            await transactionService.UpdateStateAsync(transaction, TransactionStates.Rejected, user.Id);
            throw new ResourceNotFoundException(string.Format(ErrorMessages.NotAvailableWalletBalance, typeof(Wallet).Name));
        }
    }
}
