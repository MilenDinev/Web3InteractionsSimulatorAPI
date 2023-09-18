namespace JaxWorld.Services.Handlers.TxnDeployers
{
    using Main.Interfaces;
    using Data.Entities.Wallets;
    using Models.Requests.BlockchainRequests.BlockModels;
    using Models.Requests.BlockchainRequests.TransactionModels;

    public class TransactionDeployer
    {
        private readonly IBlockService blockService;
        protected readonly ITransactionService transactionService;

        public TransactionDeployer(IBlockService blockService, ITransactionService transactionService)
        {
            this.blockService = blockService;
            this.transactionService = transactionService;
        }

        protected async Task<CreateTransactionModel> GetCreateTxnModelAsync(string state,
            int networkId, int creatorId, int initWalletId, long gasUsed, int? targetId = null)
        {
            var availableBlockId = await GetAvailableBlockIdAsync(networkId, creatorId, gasUsed);
            var transactionStateId = await transactionService.GetTransactionStateIdAsync(state);

            var createTransactionModel = new CreateTransactionModel
            {
                CreatorId = creatorId,
                BlockId = availableBlockId,
                NetworkId = networkId,
                InitiatorWalletId = initWalletId,
                StateId = transactionStateId,
            };

            if (targetId.HasValue)
                createTransactionModel.TargetId = targetId.Value;

            return createTransactionModel;
        }

        protected async Task<bool> ValidateWallet(Wallet wallet)
        {
            //update balance validation.
            return await Task.Run(() => true);
        }

        private async Task<int> GetAvailableBlockIdAsync(int networkId, int creatorId, long gasUsed)
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

            return currentBlockAvailable.Id;
        }

    }
}
