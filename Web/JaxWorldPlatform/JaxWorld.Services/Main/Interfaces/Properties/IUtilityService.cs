namespace JaxWorld.Services.Main.Interfaces.Properties
{
    using Base;
    using Data.Entities.Properties;
    using Models.Requests.BlockchainRequests.PropertiesModels;

    public interface IUtilityService : IPropertyService<Utility, CreateUtilityModel, EditUtilityModel>
    {
    }
}
