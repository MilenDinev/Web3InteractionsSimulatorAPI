namespace JaxWorld.Services.Main.Interfaces.Properties
{

    using Models.Responses.BlockchainResponses.PropertiesModels.Utility;
    using Models.Requests.BlockchainRequests.PropertiesModels;

    public interface IUtilityService 
    {
        Task<IEnumerable<UtilityListingModel>> GetAllActiveUtillitiesAsync();
        Task<UtilityListingModel> GetByIdAsync(int utilityId);
        Task<CreatedUtilityModel> CreateAsync(CreateUtilityModel utilityModel, int creatorId);
        Task<EditedUtilityModel> EditAsync(EditUtilityModel utilityModel, int utilityId, int modifierId);
        Task<DeletedUtilityModel> DeleteAsync(int utilityId, int modifierId);
    }
}
