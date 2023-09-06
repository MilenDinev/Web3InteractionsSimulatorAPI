namespace JaxWorld.Services.Main.Interfaces.Properties
{
    using Base;
    using Data.Entities.Properties;
    using Models.Requests.BlockchainRequests.PropertiesModels;
    using Models.Responses.BlockchainResponses.PropertiesModels.Attribute;

    public interface IAttributeService : IPropertyService<Attribute, CreateAttributeModel, EditAttributeModel>
    {
        Task<IEnumerable<AttributeListingModel>> GetAllActiveAsync();
        Task<AttributeListingModel> GetByIdAsync(int utilityId);
        Task<CreatedAttributeModel> CreateAsync(CreateAttributeModel utilityModel, int creatorId);
        Task<EditedAttributeModel> EditAsync(EditAttributeModel utilityModel, int utilityId, int modifierId);
        Task<DeletedAttributeModel> DeleteAsync(int utilityId, int modifierId);
    }
}
