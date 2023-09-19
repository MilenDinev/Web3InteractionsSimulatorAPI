namespace JaxWorld.Services.Handlers.TxnDeployers
{
    using Constants;
    using Main.Interfaces;
    using Data.Entities;
    using Models.Requests.BlockchainRequests.ProfileModels;
    using Models.Responses.BlockchainResponses.ProfileModels;

    public class ProfileTxnDeployer : TransactionDeployer
    {
        protected readonly IProfileService profileService;

        public ProfileTxnDeployer(IProfileService profileService,
            IBlockService blockService,
            ITransactionService transactionService
            ) : base(blockService, transactionService)
        {
            this.profileService = profileService;
        }

        public async Task<CreatedProfileModel> DeployProfileTxnAsync(CreateProfileModel createProfileModel, User user)
        {
            var networkId = await profileService.GetProfileNetworkIdAsync(createProfileModel.ContractId);

            var createTransactionModel = await GetCreateTxnModelAsync(TransactionStates.Pending, 
                TxnActions.Deploy,
                networkId, user.Id,
                user.WalletId, GasUsedParams.ContractDeployGas);

            var transaction = await transactionService.CreateAsync(createTransactionModel, createProfileModel.ContractId);

            var createdProfileModel = await profileService.CreateAsync(createProfileModel, user.Id);

            await transactionService.UpdateStateAsync(transaction, TransactionStates.Confirmed, user.Id);

            return createdProfileModel;
        }
    }
}
