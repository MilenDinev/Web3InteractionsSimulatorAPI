namespace JaxWorld.Services.Main.Interfaces
{
    using Base;
    using Data.Entities.Blockchain.Properties;
    using Models.Requests.BlockchainRequests.PropertiesModels;

    internal interface IAttributeService : IPropertyService<Attribute, CreateAttributeModel, EditAttributeModel>
    {

    }
}
