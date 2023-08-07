namespace JaxWorld.Services.Main.Interfaces
{
    using Data.Entities.Profiles;
    using Models.Requests.BlockchainRequests.ProfileModels;

    public interface IProfileService
    {
        Task<Profile> CreateAsync(CreateProfileModel model, int creatorId);
        Task EditAsync(Profile profile, EditProfileModel model, int modifierId);
        Task DeleteAsync(Profile profile, int modifierId);
    }
}
