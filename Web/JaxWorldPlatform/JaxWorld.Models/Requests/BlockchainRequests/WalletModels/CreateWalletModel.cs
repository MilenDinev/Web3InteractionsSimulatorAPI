namespace JaxWorld.Models.Requests.BlockchainRequests.WalletModels
{
    using System.ComponentModel.DataAnnotations;

    public class CreateWalletModel
    {
        [Required]
        public string Address { get; set; }
        public int ProviderId { get; set; }
        public decimal Balance { get; set; }
        [Required]
        public string Owner { get; set; }
    }
}
