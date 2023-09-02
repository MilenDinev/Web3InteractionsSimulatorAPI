namespace JaxWorld.Services.Handlers
{
    using Interfaces;
    using AutoMapper;
    using Main.Interfaces;
    using System.Globalization;
    using Microsoft.AspNetCore.Identity;
    using Models.Responses.BlockchainResponses.BlockModels;
    using Models.Requests.BlockchainRequests.ContractModels;
    using Models.Requests.BlockchainRequests.TransactionModels;
    using Models.Responses.BlockchainResponses.TransactionModels;
    using JaxWorld.Models.Requests.BlockchainRequests.BlockModels;

    public class TransactionDeployer : ITransactionDeployer
    {
        private readonly IMapper mapper;
        private readonly IContractService contractService;
        private readonly IBlockService blockService;
        private readonly ITransactionService transactionService;

        public TransactionDeployer(IMapper mapper, IContractService contractService, IBlockService blockService, ITransactionService transactionService)
        {
            this.mapper = mapper;
            this.contractService = contractService;
            this.blockService = blockService;
            this.transactionService = transactionService;
        }

        public async Task<DeployedContractTransactionModel> DeployContractAsync(CreateContractModel createContractModel, int creatorId)
        {
            var createTransactionModel = mapper.Map<CreateTransactionModel>(createContractModel);
            var transactionHash = await CreateTxnHashAsync(createContractModel.Name);
            createTransactionModel.TxnHash = transactionHash;

            var contract = await contractService.CreateAsync(createContractModel, creatorId);
            createTransactionModel.InitiatorId = contract.CreatorWalletId;
            createTransactionModel.TargetId = contract.Id;


            var createBlockModel = mapper.Map<CreateBlockModel>(createTransactionModel);
            createBlockModel.BaseFeePerGas = 0.000000025m;
            createBlockModel.GasUsed = 275345;
            createBlockModel.TxnHash = transactionHash;

            var block = await blockService.CreateAsync(createBlockModel, creatorId);

            createTransactionModel.BlockId = block.Id;

            var transaction = await transactionService.CreateAsync(createTransactionModel, creatorId);
            //await this.transactionService.UpdateStateAsync(transaction);


            var deployedContractModel = new DeployedContractTransactionModel
            {
                ContractId = contract.Id,
                TxnHash = transaction.TxnHash,
                TxnState = createTransactionModel.State,
                ContractName = contract.Name,
                ContractAddress = contract.Address,
                CreatorAddress = createContractModel.CreatorAddress,
                OwnerAddress = createContractModel.CreatorAddress,
            };



            return await Task.Run(() => deployedContractModel);
        }

        private static async Task<string> CreateTxnHashAsync(string hashKey)
        {
            var hasher = new PasswordHasher<string>();
            var timestamp = DateTime.UtcNow.ToString("F", CultureInfo.InvariantCulture);
            var txnHash = hasher.HashPassword(hashKey, timestamp);

            return await Task.Run(txnHash.ToString);
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
