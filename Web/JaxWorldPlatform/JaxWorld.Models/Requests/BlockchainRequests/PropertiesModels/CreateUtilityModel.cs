namespace JaxWorld.Models.Requests.BlockchainRequests.PropertiesModels
{
    using Base;

    public class CreateUtilityModel : CreatePropertyModel
    {
        public string DisplayType { get; set; }
        public decimal Value { get; set; }
    }
}
