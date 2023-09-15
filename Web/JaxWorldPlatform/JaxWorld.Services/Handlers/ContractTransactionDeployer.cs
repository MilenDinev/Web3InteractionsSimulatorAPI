namespace JaxWorld.Services.Handlers
{
    using Constants;
    using Main.Interfaces;
    using Data.Entities;
    using Models.Requests.BlockchainRequests.ContractModels;

    public class ContractTransactionDeployer : TransactionDeployer
    {
        protected readonly IContractService contractService;

        public ContractTransactionDeployer(IContractService contractService, IBlockService blockService, ITransactionService transactionService) : base(blockService, transactionService)
        {
            this.contractService = contractService;
        }

        public async Task DeployContractTxnAsync(CreateContractModel createContractModel, User user)
        {
            var createdContractModel = await this.contractService.CreateAsync(createContractModel, user);

            var createTransactionModel = await GetCreateTxnModelAsync(createdContractModel, GasUsedParams.ContractDeployGas);

            var transaction = await this.transactionService.CreateAsync(createTransactionModel, createdContractModel.Id);

            await this.transactionService.UpdateStateAsync(transaction, transaction.CreatorId);

        }
    }
}
