namespace JaxWorld.Services.Handlers
{
    using Interfaces;
    using Main.Interfaces;
    using Models.Requests.BlockchainRequests.BlockModels;
    using Models.Responses.BlockchainResponses.ProfileModels;
    using Models.Responses.BlockchainResponses.ContractModels;
    using Models.Requests.BlockchainRequests.TransactionModels;
    using Models.Responses.BlockchainResponses.TransactionModels;
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

        public async Task<DeployedContractTxnModel> DeployContractTxnAsync(CreatedContractModel createdContractModel, int creatorId)
        {
            var createTransactionModel = await GetCreateTxnModelAsync(creatorId, createdContractModel.NetworkId, createdContractModel.CreatorWalletId);

            var transaction = await transactionService.CreateAsync(createTransactionModel, createdContractModel.Id);

            await this.transactionService.UpdateStateAsync(transaction, transaction.CreatorId);

            var deployedContractModel = new DeployedContractTxnModel
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

        public async Task<DeployedProfileTxnModel> DeployProfileTxnAsync(CreatedProfileModel createdProfileModel, int creatorId)
        {
            var createTransactionModel = await GetCreateTxnModelAsync(creatorId, createdProfileModel.NetworkId, createdProfileModel.CreatorWalletId);
            var transaction = await transactionService.CreateAsync(createTransactionModel, createdProfileModel.ContractId);

            await this.transactionService.UpdateStateAsync(transaction, transaction.CreatorId);

            var deployedProfileModel = new DeployedProfileTxnModel
            {
                ProfileId = transaction.Target.Profile.Id,
                ProfileName = transaction.Target.Profile.Name,
                Standard = transaction.Target.Profile.Standard.Name,
                Symbol = transaction.Target.Profile.Symbol,
                Description = transaction.Target.Profile.Description,
                TotalSupply = transaction.Target.Profile.TotalSupply,
                ContractAddress = transaction.Target.Address,
            };


            return await Task.Run(() => deployedProfileModel);
        }

        public async Task<MintedErc721aUnitTxnModel> MintedErc721aUnitTxnAsync(CreatedErc721aUnitModel createdErc721aUnitModel, int creatorId)
        {
            var createTransactionModel = await GetCreateTxnModelAsync(creatorId, createdErc721aUnitModel.NetworkId, createdErc721aUnitModel.MinterId);
            var transaction = await transactionService.CreateAsync(createTransactionModel, createdErc721aUnitModel.ContractId);

            await this.transactionService.UpdateStateAsync(transaction, transaction.CreatorId);

            var mintedErc721aUnitModel = new MintedErc721aUnitTxnModel
            {
                //Name = transaction.Target.Profile.Erc721aUnits.Select(x => x.Name.Where(y => x.Name== createdErc721aUnitModel.Name).FirstOrDefault(),
                Id = transaction.CreatorId,
                Name = createdErc721aUnitModel.Name,
                MinterAddress = createdErc721aUnitModel.MinterAddress,
                ContractAddress = transaction.Target.Address,
                TxnHash = transaction.TxnHash,
                
                
            };


            return await Task.Run(() => mintedErc721aUnitModel);
        }

        public async Task<TransferedUnitTransactionModel> TransferAsync(TransferUnitTransactionModel initiateTransactionModel, int creatorId)
        {
            throw new NotImplementedException();
        }

        public async Task<ClaimedUnitTransactionModel> ClaimAsync(ClaimUnitTransactionModel initiateTransactionModel, int creatorId)
        {
            throw new NotImplementedException();
        }

        private async Task<CreateTransactionModel> GetCreateTxnModelAsync(int creatorId, int networkId, int initWalletId)
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

    }
}
