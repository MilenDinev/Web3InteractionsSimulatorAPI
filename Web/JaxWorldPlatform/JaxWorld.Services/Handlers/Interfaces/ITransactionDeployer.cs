namespace JaxWorld.Services.Handlers.Interfaces
{
    using JaxWorld.Models.Requests.BlockchainRequests.ContractModels;
    using Models.Requests.BlockchainRequests.TransactionModels;
    using Models.Responses.BlockchainResponses.TransactionModels;

    public interface ITransactionDeployer
    {
        Task<DeployedContractTransactionModel> DeployContractAsync(CreateContractModel createContractModel, int creatorId);
        Task<TransferedUnitTransactionModel> TransferAsync(TransferUnitTransactionModel initiateTransactionModel, int creatorId);
        Task<ClaimedUnitTransactionModel> ClaimAsync(ClaimUnitTransactionModel initiateTransactionModel, int creatorId);
    }
}
