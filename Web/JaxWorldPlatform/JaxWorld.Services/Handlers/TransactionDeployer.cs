namespace JaxWorld.Services.Handlers
{
    using Constants;
    using Interfaces;
    using Main.Interfaces;
    using Models.Responses.BlockchainResponses.Interfaces;
    using Models.Responses.BlockchainResponses.ProfileModels;
    using Models.Responses.BlockchainResponses.ProfileUnitModels;
    using Models.Requests.BlockchainRequests.BlockModels;
    using Models.Requests.BlockchainRequests.TransactionModels;

    public class TransactionDeployer : ITransactionDeployer
    {
        private readonly IBlockService blockService;
        protected readonly ITransactionService transactionService;

        public TransactionDeployer(IBlockService blockService, ITransactionService transactionService)
        {
            this.blockService = blockService;
            this.transactionService = transactionService;
        }


        public async Task DeployProfileTxnAsync(CreatedProfileModel createdProfileModel, int creatorId)
        {
            var createTransactionModel = await GetCreateTxnModelAsync(createdProfileModel, GasUsedParams.ProfileDeployGas);
            var transaction = await transactionService.CreateAsync(createTransactionModel, createdProfileModel.Id);

            await this.transactionService.UpdateStateAsync(transaction, transaction.CreatorId);

        }

        public async Task MintErc721aUnitTxnAsync(CreatedErc721aUnitModel createdErc721aUnitModel, int creatorId)
        {
            var createTransactionModel = await GetCreateTxnModelAsync(createdErc721aUnitModel,GasUsedParams.Erc721aMintGas);
            var transaction = await transactionService.CreateAsync(createTransactionModel, createdErc721aUnitModel.Id);

            await this.transactionService.UpdateStateAsync(transaction, transaction.CreatorId);

        }

        internal async Task<CreateTransactionModel> GetCreateTxnModelAsync<T>(T createdModel, long gasUsed) where T : class, ICreated
        {
            var availableBlockId = await GetAvailableBlockAsync(createdModel.NetworkId, createdModel.CreatorId, gasUsed);

            var createTransactionModel = new CreateTransactionModel
            {
                CreatorId = createdModel.CreatorId,
                BlockId = availableBlockId,
                NetworkId = createdModel.NetworkId,
                InitiatorWalletId = createdModel.CreatorWalletId,
                TargetId = createdModel.Id,
                StateId = 1,
            };

            return await Task.Run(() => createTransactionModel);
        }

        internal async Task<int> GetAvailableBlockAsync(int networkId, int creatorId, long gasUsed)
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
