namespace JaxWorld.Models.Requests.BlockchainRequests.PropertiesModels.Base
{
    using Interfaces;

    public abstract class CreatePropertyModel<T> : ICreatePropertyModel<T>
    {
        public string Name { get; set; }
        public T Value { get; set; }
    }
}
