namespace JaxWorld.Models.Requests.BlockchainRequests.PropertiesModels.Base.Interfaces
{
    using BlockchainRequests.Interfaces;

    public interface IEditPropertyModel : IEditModel
    {
        public string? TraitType { get;}
    }
}
