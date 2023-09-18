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
            var createTransactionModel = await GetCreateTxnModelAsync(TransactionStates.Pending,
                createContractModel.NetworkId, user.Id,
                user.WalletId, GasUsedParams.ContractDeployGas);

            //update wallet validation.
            var isValidWallet = await ValidateWallet(user.Wallet);

            if (isValidWallet)
            {
                var transaction = await transactionService.CreateAsync(createTransactionModel);

                var createdContractModel = await contractService.CreateAsync(createContractModel, user);

                transaction.TargetId = createdContractModel.Id;

                await transactionService.UpdateStateAsync(transaction, TransactionStates.Confirmed, user.Id);

                return createdContractModel;

            }

            var rejectedtransaction = await transactionService.CreateAsync(createTransactionModel);
            await transactionService.UpdateStateAsync(rejectedtransaction, TransactionStates.Rejected, user.Id);

            throw new ResourceNotFoundException(string.Format(ErrorMessages.NotAvailableWalletBalnce, typeof(Wallet).Name));
        }
    }
}
