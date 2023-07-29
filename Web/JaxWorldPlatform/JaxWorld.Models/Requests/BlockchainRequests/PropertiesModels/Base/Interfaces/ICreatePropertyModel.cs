namespace JaxWorld.Models.Requests.BlockchainRequests.PropertiesModels.Base.Interfaces
{
    using BlockchainRequests.Interfaces;

    public interface ICreatePropertyModel<T> : ICreateModel
    {
        public string Name { get; set; }
        public T Value { get; set; }
    }
}
