namespace JaxWorld.Models.Responses.BlockchainResponses.WalletModels
{
    public class CreatedWalletModel
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Provider { get; set; }
        public decimal Balance { get; set; }
        public string Owner { get; set; }
    }
}
