namespace JaxWorld.Services.Handlers.Interfaces
{
    using Data.Entities;
    using Models.Responses.BlockchainResponses.ContractModels;
    using Models.Requests.BlockchainRequests.TransactionModels;
    using Models.Responses.BlockchainResponses.TransactionModels;

    public interface ITransactionDeployer
    {
        Task<DeployedContractTransactionModel> DeployContractAsync(CreatedContractModel createdContractModel, User creator);
        Task<TransferedUnitTransactionModel> TransferAsync(TransferUnitTransactionModel initiateTransactionModel, int creatorId);
        Task<ClaimedUnitTransactionModel> ClaimAsync(ClaimUnitTransactionModel initiateTransactionModel, int creatorId);
    }
}
