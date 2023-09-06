namespace JaxWorld.Services.Main.Interfaces
{
    using Models.Responses.BlockchainResponses.ProfileModels;
    using Models.Requests.BlockchainRequests.ProfileModels;

    public interface IProfileService
    {
        Task<CreatedProfileModel> CreateAsync(CreateProfileModel model, int creatorId);
        Task<EditedProfileModel> EditAsync(EditProfileModel profileModel, int profileId, int modifierId);
        Task<DeletedProfileModel> DeleteAsync(int profileId, int modifierId);
        Task<IEnumerable<ProfileListingModel>> GetAllActiveAsync();
        Task<ProfileListingModel> GetByIdAsync(int profileId);
    }
}
