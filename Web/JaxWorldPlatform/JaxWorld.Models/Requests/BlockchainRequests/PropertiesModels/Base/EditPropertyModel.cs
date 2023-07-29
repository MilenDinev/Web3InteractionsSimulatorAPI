namespace JaxWorld.Models.Requests.BlockchainRequests.PropertiesModels.Base
{
    using Interfaces;

    public abstract class EditPropertyModel : IEditPropertyModel
    {
        public string Name { get; set; }
    }
}
