namespace JaxWorld.Services.Handlers
{
    using Interfaces;
    using Main.Interfaces;
    using Models.Requests.BlockchainRequests.BlockModels;
    using Models.Requests.BlockchainRequests.TransactionModels;
    using Models.Responses.BlockchainResponses.ContractModels;
    using Models.Responses.BlockchainResponses.ProfileModels;
    using Models.Responses.BlockchainResponses.ProfileUnitModels;

    public class TransactionDeployer : ITransactionDeployer
    {
        private readonly IBlockService blockService;
        private readonly ITransactionService transactionService;

        public TransactionDeployer(IBlockService blockService, ITransactionService transactionService)
        {
            this.blockService = blockService;
            this.transactionService = transactionService;
        }

        public async Task DeployContractTxnAsync(CreatedContractModel createdContractModel, int creatorId, int initiatorWalletId)
        {
            var createTransactionModel = await GetCreateTxnModelAsync(creatorId, initiatorWalletId, createdContractModel.NetworkId, 525345);

            var transaction = await transactionService.CreateAsync(createTransactionModel, createdContractModel.Id);

            await this.transactionService.UpdateStateAsync(transaction, transaction.CreatorId);

        }

        public async Task DeployProfileTxnAsync(CreatedProfileModel createdProfileModel, int creatorId)
        {
            var createTransactionModel = await GetCreateTxnModelAsync(creatorId, createdProfileModel.Id, createdProfileModel.Id, 423421);
            var transaction = await transactionService.CreateAsync(createTransactionModel, createdProfileModel.Id);

            await this.transactionService.UpdateStateAsync(transaction, transaction.CreatorId);

        }

        public async Task MintErc721aUnitTxnAsync(CreatedErc721aUnitModel createdErc721aUnitModel, int creatorId)
        {
            var createTransactionModel = await GetCreateTxnModelAsync(creatorId, createdErc721aUnitModel.Id, createdErc721aUnitModel.Id, 325345);
            var transaction = await transactionService.CreateAsync(createTransactionModel, createdErc721aUnitModel.Id);

            await this.transactionService.UpdateStateAsync(transaction, transaction.CreatorId);

        }

        private async Task<CreateTransactionModel> GetCreateTxnModelAsync(int creatorId, int initWalletId, int networkId, long gasUsed)
        {
            var availableBlockId = await GetAvailableBlockAsync(networkId, creatorId, gasUsed);

            var createTransactionModel = new CreateTransactionModel
            {
                CreatorId = creatorId,
                BlockId = availableBlockId,
                NetworkId = networkId,
                InitiatorWalletId = initWalletId,
                StateId = 1,
            };

            return await Task.Run(() => createTransactionModel);
        }

        private async Task<int> GetAvailableBlockAsync(int networkId, int creatorId, long gasUsed)
        {
            var currentBlockAvailable = await blockService.GetCurrentBlockAsync(gasUsed);

            if (currentBlockAvailable == null)
            {
                var createBlockModel = new CreateBlockModel
                {
                    NetworkId = networkId,
                    BaseFeePerGas = 0.000000025m,
                    GasUsed = gasUsed,
                    TxnHash = "test"
                };

                var newBlock = await blockService.CreateAsync(createBlockModel, creatorId);
                return newBlock.Id;
            }

            currentBlockAvailable.GasUsed += gasUsed;

            return await Task.Run(() => currentBlockAvailable.Id);
        }

    }
}
