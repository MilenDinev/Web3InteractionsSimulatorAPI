namespace JaxWorld.Services.Main.Interfaces
{
    using Data.Entities.Profiles;
    using Models.Responses.BlockchainResponses.ProfileModels;
    using Models.Requests.BlockchainRequests.ProfileModels;

    public interface IProfileService
    {
        Task<CreatedProfileModel> CreateAsync(CreateProfileModel model, int creatorId);
        Task EditAsync(Profile profile, EditProfileModel model, int modifierId);
        Task DeleteAsync(Profile profile, int modifierId);
    }
}
