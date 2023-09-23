namespace JaxWorld.Services.Handlers.TxnManagers
{
    using Constants;
    using Exceptions;
    using Main.Interfaces;
    using Interfaces.ITxnManagers;
    using Data.Entities;
    using Data.Entities.Wallets;
    using Data.Entities.Transactions;
    using Models.Requests.BlockchainRequests.BlockModels;
    using Models.Requests.BlockchainRequests.TransactionModels;

    public abstract class TxnDeployerManager : ITxnDeployerManager
    {
        private readonly ITransactionService transactionService;
        private readonly IBlockService blockService;

        public TxnDeployerManager(ITransactionService transactionService, IBlockService blockService)
        {
            this.transactionService = transactionService;
            this.blockService = blockService;
        }

        public async Task<CreateTransactionModel> GetCreateTxnModelAsync(string state, 
            string action,
            int networkId, 
            int creatorId, 
            int initWalletId,
            long gasUsed,
            int? targetId = null)
        {
            var availableBlockId = await this.GetAvailableBlockIdAsync(networkId, creatorId, gasUsed);
            var txnStateId = await this.transactionService.GetTransactionStateIdAsync(state);
            var txnActionId = await this.transactionService.GetTxnActioIdAsync(action);

            var createTransactionModel = new CreateTransactionModel
            {
                CreatorId = creatorId,
                NetworkId = networkId,
                InitiatorWalletId = initWalletId,
                StateId = txnStateId,
                TxnActionId = txnActionId,
                BlockId = availableBlockId
            };

            if (targetId.HasValue)
                createTransactionModel.TargetId = targetId.Value;

            return createTransactionModel;
        }

        protected async Task<int> GetTxnActionIdAsync(string action)
        {
            return await this.transactionService.GetTxnActioIdAsync(action);
        }

        protected async Task<int> GetTransactionStateIdAsync(string state)
        {
            return await this.transactionService.GetTransactionStateIdAsync(state);
        }

        public async Task<Transaction> CreateTxnAsync(CreateTransactionModel createTxnModel, int? targetContract = null)
        {
            return await this.transactionService.CreateAsync(createTxnModel);
        }

        public async Task UpdateTxnStateAsync(Transaction transaction, string state, int userId)
        {
            await transactionService.UpdateStateAsync(transaction, state, userId);
        }

        public async Task<Contract> GetProfileContractAsync(Wallet wallet, int profileId)
        {
            var contract = await Task.Run(() => wallet.CreatedContracts.FirstOrDefault(c => c.Profile.Id == profileId))
            ?? throw new ResourceNotFoundException(string.Format(ErrorMessages.EntityDoesNotExist,
            typeof(Profile).Name));

            return contract;
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
