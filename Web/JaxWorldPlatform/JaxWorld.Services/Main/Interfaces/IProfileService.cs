namespace JaxWorld.Services.Main.Interfaces
{
    using Data.Entities.Blockchain.Profiles.Base;
    using Models.Requests.BlockchainRequests.ProfileModels;

    public interface IProfileService
    {
        Task<Profile> CreateAsync(CreateProfileModel model, int creatorId);
        Task EditAsync(Profile contract, EditProfileModel model, int modifierId);
        Task DeleteAsync(Profile contract, int modifierId);
    }
}
