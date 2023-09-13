namespace JaxWorld.Services.Handlers.Interfaces
{
    using Models.Responses.BlockchainResponses.ContractModels;
    using Models.Responses.BlockchainResponses.ProfileModels;
    using Models.Responses.BlockchainResponses.ProfileUnitModels;

    public interface ITransactionDeployer
    {
        Task DeployContractTxnAsync(CreatedContractModel createdContractModel, int creatorId, int initiatorWalletId);
        Task DeployProfileTxnAsync(CreatedProfileModel createdProfileModel, int creatorId);
        Task MintErc721aUnitTxnAsync(CreatedErc721aUnitModel createdErc721aModel, int creatorId);
    }
}
