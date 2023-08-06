namespace JaxWorld.Models.Responses.BlockchainResponses.WalletModels
{
    public class WalletListingModel
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Provider { get; set; }
        public string Balance { get; set; }
        public string Owner { get; set; }
    }
}
