namespace JaxWorld.Services.Handlers
{
    using Interfaces;
    using Main.Interfaces;
    using Models.Requests.BlockchainRequests.BlockModels;
    using Models.Requests.BlockchainRequests.TransactionModels;
    using Models.Responses.BlockchainResponses.TransactionModels;

    public class TransactionDeployer : ITransactionDeployer
    {
        private readonly IBlockService blockService;
        private readonly ITransactionService transactionService;

        public TransactionDeployer(IBlockService blockService, ITransactionService transactionService)
        {
            this.blockService = blockService;
            this.transactionService = transactionService;
        }

        public async Task<CreateTransactionModel> GetCreateTransactionModelAsync(int creatorId, int networkId, int initWalletId)
        {
            var availableBlockId = await GetAvailableBlockAsync(networkId, creatorId);
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

        public async Task<DeployedContractTransactionModel> DeployTransactionAsync(CreateTransactionModel createTransactionModel, int targetContractId)
            {
            var transaction = await transactionService.CreateAsync(createTransactionModel, targetContractId);
            await this.transactionService.UpdateStateAsync(transaction, createTransactionModel.StateId + 1, transaction.CreatorId);

            var deployedContractModel = new DeployedContractTransactionModel
            {
                ContractId = transaction.TargetId,
                BlockId = transaction.BlockId,
                TxnHash = transaction.TxnHash,
                ContractName = transaction.Target.Name,
                TxnState = transaction.State.State,
                ContractAddress = transaction.Target.Address,
                CreatorAddress = transaction.Initiator.Address,
                OwnerAddress = transaction.Initiator.Address,
            };


            return await Task.Run(() => deployedContractModel);
        }

        private async Task<int> GetAvailableBlockAsync(int networkId, int creatorId)
        {
            var currentBlockAvailable = await blockService.GetCurrentBlockAsync();

            if (currentBlockAvailable == null)
            {
                var createBlockModel = new CreateBlockModel
        {
                    NetworkId = networkId,
                    BaseFeePerGas = 0.000000025m,
                    GasUsed = 275345,
                    TxnHash = "test"
                };

                var newBlock = await blockService.CreateAsync(createBlockModel, creatorId);
                return newBlock.Id;
            }

            currentBlockAvailable.GasUsed += 275345;

            return await Task.Run(() => currentBlockAvailable.Id);
        }

        public async Task<TransferedUnitTransactionModel> TransferAsync(TransferUnitTransactionModel initiateTransactionModel, int creatorId)
        {
            throw new NotImplementedException();
        }

        public async Task<ClaimedUnitTransactionModel> ClaimAsync(ClaimUnitTransactionModel initiateTransactionModel, int creatorId)
        {
            throw new NotImplementedException();
        }
    }
}
