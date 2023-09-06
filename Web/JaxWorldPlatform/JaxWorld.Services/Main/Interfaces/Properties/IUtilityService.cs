namespace JaxWorld.Services.Main.Interfaces.Properties
{
    using Base;
    using Data.Entities.Properties;
    using Models.Responses.BlockchainResponses.PropertiesModels.Utility;
    using Models.Requests.BlockchainRequests.PropertiesModels;

    public interface IUtilityService : IPropertyService<Utility, CreateUtilityModel, EditUtilityModel>
    {
        Task<IEnumerable<UtilityListingModel>> GetAllActiveAsync();
        Task<UtilityListingModel> GetByIdAsync(int utilityId);
        Task<CreatedUtilityModel> CreateAsync(CreateUtilityModel utilityModel, int creatorId);
        Task<EditedUtilityModel> EditAsync(EditUtilityModel utilityModel, int utilityId, int modifierId);
        Task<DeletedUtilityModel> DeleteAsync(int utilityId, int modifierId);
    }
}
