namespace JaxWorld.Services.Managers
{
    using System.Threading.Tasks;
    using Interfaces;
    using AutoMapper;
    using Models.Requests.BlockchainRequests.TransactionModels;
    using Models.Responses.BlockchainResponses.TransactionModels;

    public class TransactionDeployer : ITransactionDeployer
    {
        private readonly IMapper mapper;

        public TransactionDeployer(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public async Task<DeployedContractTransactionModel> DeployContractAsync(DeployContractTransactionModel deployContractModel, int creatorId)
        {
            throw new NotImplementedException();
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
