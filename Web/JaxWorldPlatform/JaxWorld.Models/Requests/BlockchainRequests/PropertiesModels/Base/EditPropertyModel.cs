namespace JaxWorld.Models.Requests.BlockchainRequests.PropertiesModels.Base
{
    using Interfaces;

    public class EditPropertyModel<T> : IEditPropertyModel<T>
    {
        public string Name { get; set; }
        public T Value { get; set; }
    }
}
