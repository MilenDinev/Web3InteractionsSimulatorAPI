namespace JaxWorld.Services.Main.Interfaces.Properties
{
    using Base;
    using Data.Entities.Blockchain.Properties;
    using Models.Requests.BlockchainRequests.PropertiesModels;

    public interface IAttributeService : IPropertyService<Attribute, CreateAttributeModel, EditAttributeModel>
    {

    }
}
