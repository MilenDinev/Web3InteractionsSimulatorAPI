namespace JaxWorld.Services.Handlers
{
    using System.Globalization;
    using Data.Entities;
    using Interfaces;
    using Main.Interfaces;
    using Microsoft.AspNetCore.Identity;
    using Models.Requests.BlockchainRequests.BlockModels;
    using Models.Responses.BlockchainResponses.ContractModels;
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

        public async Task<DeployedContractTransactionModel> DeployContractAsync(CreatedContractModel createdContractModel, User creator)
        {
            var transactionHash = await CreateTxnHashAsync(createdContractModel.CreatorWallet);

            var createTransactionModel = new CreateTransactionModel
            {
                TxnHash = transactionHash,
                InitiatorId = createdContractModel.CreatorWalletId,
                TargetId = createdContractModel.CreatorWalletId,
                StateId = 1,
            };

            var createBlockModel = new CreateBlockModel
            {
                BaseFeePerGas = 0.000000025m,
                GasUsed = 275345,
                TxnHash = transactionHash
            };

            var block = await blockService.CreateAsync(createBlockModel, creator.Id);

            createTransactionModel.BlockId = block.Id;

            var transaction = await transactionService.CreateAsync(createTransactionModel, creator.Id);

            var deployedContractModel = new DeployedContractTransactionModel
            {
                ContractId = createdContractModel.Id,
                TxnHash = transaction.TxnHash,
                ContractName = createdContractModel.Name,
                ContractAddress = createdContractModel.Address,
                CreatorAddress = createdContractModel.CreatorWallet,
                OwnerAddress = createdContractModel.OwnerWallet,
            };

            await this.transactionService.UpdateStateAsync(transaction, createTransactionModel.StateId + 1, creator.Id);

            deployedContractModel.TxnState = transaction.State.State;

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
