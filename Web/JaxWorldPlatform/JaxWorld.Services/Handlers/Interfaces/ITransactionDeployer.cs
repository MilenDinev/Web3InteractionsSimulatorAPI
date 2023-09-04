namespace JaxWorld.Services.Handlers.Interfaces
{
    using Models.Requests.BlockchainRequests.TransactionModels;
    using Models.Responses.BlockchainResponses.TransactionModels;

    public interface ITransactionDeployer
    {
        Task<DeployedContractTxnModel> DeployContractTxnAsync(CreatedContractModel createdContractModel, int creatorId);
        Task<DeployedContractTransactionModel> DeployTransactionAsync(CreateTransactionModel createTransactionModel, int targetContractId);
        Task<TransferedUnitTransactionModel> TransferAsync(TransferUnitTransactionModel initiateTransactionModel, int creatorId);
        Task<ClaimedUnitTransactionModel> ClaimAsync(ClaimUnitTransactionModel initiateTransactionModel, int creatorId);
    }
}
