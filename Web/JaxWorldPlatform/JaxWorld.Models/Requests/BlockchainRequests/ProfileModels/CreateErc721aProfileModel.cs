namespace JaxWorld.Models.Requests.BlockchainRequests.ProfileModels
{
    public class CreateErc721aProfileModel
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string Description { get; set; }
        public int TotalSupply { get; set; }
        public int StandardId { get; set; }
        public int ContractId { get; set; }
    }
}
