namespace JaxWorld.Services.Main.Interfaces
{
    using Models.Requests.BlockchainRequests.ProfileModels;
    using Models.Responses.BlockchainResponses.ProfileModels;

    public interface IProfileService
    {
        Task<CreatedProfileModel> CreateAsync(CreateProfileModel model, int creatorId);
        Task<EditedProfileModel> EditAsync(EditProfileModel profileModel, int profileId, int modifierId);
        Task<DeletedProfileModel> DeleteAsync(int profileId, int modifierId);
        Task<IEnumerable<ProfileListingModel>> GetAllActiveProfilesAsync();
        Task<ProfileListingModel> GetByIdAsync(int profileId);
    }
}
