namespace JaxWorld.Services.Managers.Interfaces
{
    using Models.Requests.BlockchainRequests.TransactionModels;
    using Models.Responses.BlockchainResponses.TransactionModels;

    public interface ITransactionDeployer
    {
       Task<DeployedContractTransactionModel> DeployContractAsync(DeployContractTransactionModel deployContractModel, int creatorId);
       Task<TransferedUnitTransactionModel> TransferAsync(TransferUnitTransactionModel initiateTransactionModel, int creatorId);
       Task<ClaimedUnitTransactionModel> ClaimAsync(ClaimUnitTransactionModel initiateTransactionModel, int creatorId);
    }
}
