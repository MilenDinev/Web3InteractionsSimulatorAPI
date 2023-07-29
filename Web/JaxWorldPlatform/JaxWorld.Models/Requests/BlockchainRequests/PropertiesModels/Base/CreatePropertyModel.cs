namespace JaxWorld.Models.Requests.BlockchainRequests.PropertiesModels.Base
{
    using Interfaces;

    public abstract class CreatePropertyModel : ICreatePropertyModel
    {
        public string Name { get; set; }
    }
}
