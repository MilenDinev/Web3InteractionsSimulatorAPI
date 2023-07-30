namespace JaxWorld.Models.Requests.BlockchainRequests.WalletModels
{
    public class CreateWalletModel
    {
        public string Address { get; set; }
        public string Provider { get; set; }
        public decimal Balance { get; set; }
        public string Owner { get; set; }
    }
}
