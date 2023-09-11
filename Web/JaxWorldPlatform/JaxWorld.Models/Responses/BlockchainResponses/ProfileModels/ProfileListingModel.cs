namespace JaxWorld.Models.Responses.BlockchainResponses.ProfileModels
{
    public class ProfileListingModel
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string Description { get; set; }
        public int TotalSupply { get; set; }
        public string Standard { get; set; }
        public string ContractAddress { get; set; }
        public string CreatorAddress { get; set; }
        public string CreationTnxHash { get; set; }
    }
}
