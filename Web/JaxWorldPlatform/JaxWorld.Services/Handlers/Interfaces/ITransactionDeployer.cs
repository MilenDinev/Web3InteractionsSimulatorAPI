namespace JaxWorld.Services.Handlers.Interfaces
{
    using Models.Responses.BlockchainResponses.ProfileModels;
    using Models.Responses.BlockchainResponses.ContractModels;
    using Models.Requests.BlockchainRequests.TransactionModels;
    using Models.Responses.BlockchainResponses.TransactionModels;
    using Models.Responses.BlockchainResponses.ProfileUnitModels;

    public interface ITransactionDeployer
    {
        Task<DeployedContractTxnModel> DeployContractTxnAsync(CreatedContractModel createdContractModel, int creatorId);
        Task<DeployedProfileTxnModel> DeployProfileTxnAsync(CreatedProfileModel createdProfileModel, int creatorId);
        Task<MintedErc721aUnitTxnModel> MintedErc721aUnitTxnAsync(CreatedErc721aUnitModel createdErc721aModel, int creatorId);
        Task<TransferedUnitTransactionModel> TransferAsync(TransferUnitTransactionModel initiateTransactionModel, int creatorId);
        Task<ClaimedUnitTransactionModel> ClaimAsync(ClaimUnitTransactionModel initiateTransactionModel, int creatorId);
    }
}
