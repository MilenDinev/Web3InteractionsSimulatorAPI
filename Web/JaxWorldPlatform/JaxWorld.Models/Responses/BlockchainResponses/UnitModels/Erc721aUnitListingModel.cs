namespace JaxWorld.Models.Responses.BlockchainResponses.UnitModels
{
    public class Erc721aUnitListingModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string? ImageUrl { get; set; }
        public string HolderAddress { get; set; }
        public string ContractAddress { get; set; }
        public string? ExternalUrl { get; set; }
    }
}
