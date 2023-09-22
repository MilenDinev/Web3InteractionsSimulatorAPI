namespace JaxWorld.Services.Handlers.TxnManagers
{
    using Main.Interfaces;
    using Interfaces.ITxnManagers;
    using Models.Requests.BlockchainRequests.ProfileModels;
    using Models.Responses.BlockchainResponses.ProfileModels;

    public class ProfileTxnDeployerManager : TxnDeployerManager, IProfileTxnDeployerManager
    {
        private readonly IProfileService profileService;

        public ProfileTxnDeployerManager(IProfileService profileService,
            ITransactionService transactionService, IBlockService blockService) : base(transactionService, blockService)
        {
            this.profileService = profileService;
        }

        public async Task<int> GetProfileNetworkIdAsync(int contractId)
        {
            return await profileService.GetProfileNetworkIdAsync(contractId);
        }  
        
        public async Task<CreatedProfileModel> CreateProfileAsync(CreateProfileModel createProfileModel, int userId)
        {
            return await profileService.CreateAsync(createProfileModel, userId);
        }
    }
}
