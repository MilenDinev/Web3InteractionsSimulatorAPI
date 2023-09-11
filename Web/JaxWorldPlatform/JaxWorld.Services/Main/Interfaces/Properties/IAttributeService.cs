namespace JaxWorld.Services.Main.Interfaces.Properties
{
    using Models.Requests.BlockchainRequests.PropertiesModels;
    using Models.Responses.BlockchainResponses.PropertiesModels.Attribute;

    public interface IAttributeService
    {
        Task<IEnumerable<AttributeListingModel>> GetAllActiveAttributesAsync();
        Task<AttributeListingModel> GetByIdAsync(int utilityId);
        Task<CreatedAttributeModel> CreateAsync(CreateAttributeModel utilityModel, int creatorId);
        Task<EditedAttributeModel> EditAsync(EditAttributeModel utilityModel, int utilityId, int modifierId);
        Task<DeletedAttributeModel> DeleteAsync(int utilityId, int modifierId);
    }
}
