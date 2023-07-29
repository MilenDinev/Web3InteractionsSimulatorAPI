namespace JaxWorld.Models.Requests.BlockchainRequests.PropertiesModels.Base.Interfaces
{
    using BlockchainRequests.Interfaces;

    public interface ICreatePropertyModel : ICreateModel
    {
        public string Name { get; set; }
    }
}
