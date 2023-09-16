namespace JaxWorld.Services.Handlers
{
    using Constants;
    using Main.Interfaces;
    using Data.Entities;
    using Models.Requests.BlockchainRequests.ProfileModels;
    using JaxWorld.Models.Requests.BlockchainRequests.ContractModels;
    using JaxWorld.Models.Responses.BlockchainResponses.ContractModels;
    using JaxWorld.Models.Responses.BlockchainResponses.ProfileModels;

    public class ProfileTransactionDeployer : TransactionDeployer
    {
        protected readonly IProfileService profileService;

        public ProfileTransactionDeployer(IProfileService profileService, 
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
                networkId, user.Id,
                user.WalletId, GasUsedParams.ContractDeployGas);

            var transaction = await transactionService.CreateAsync(createTransactionModel, createProfileModel.ContractId);

            var createdProfileModel = await this.profileService.CreateAsync(createProfileModel, user.Id);

            await this.transactionService.UpdateStateAsync(transaction, TransactionStates.Confirmed, user.Id);

            return createdProfileModel;
        }
    }
}
