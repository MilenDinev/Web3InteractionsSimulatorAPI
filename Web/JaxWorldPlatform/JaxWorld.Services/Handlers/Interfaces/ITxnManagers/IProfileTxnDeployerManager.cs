namespace JaxWorld.Services.Handlers.Interfaces.ITxnManagers
{
    using Data.Entities.Wallets;
    using Data.Entities.Contracts;
    using JaxWorld.Models.Requests.BlockchainRequests.ProfileModels;
    using JaxWorld.Models.Responses.BlockchainResponses.ProfileModels;

    public interface IProfileTxnDeployerManager : ITxnDeployerManager
    {
        Task<Contract> GetProfileContractAsync(Wallet wallet, int profileId);
        Task<int> GetProfileNetworkIdAsync(int contractId);
        Task<CreatedProfileModel> CreateProfileAsync(CreateProfileModel createProfileModel, int userId);
    }
}
