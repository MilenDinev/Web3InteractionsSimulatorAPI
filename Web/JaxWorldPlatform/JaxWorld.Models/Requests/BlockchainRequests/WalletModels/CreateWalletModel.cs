namespace JaxWorld.Models.Requests.BlockchainRequests.WalletModels
{
    using System.ComponentModel.DataAnnotations;

    public class CreateWalletModel
    {
        [Required(ErrorMessage = "Wallet address is required and must be between 5 and 50 symbols!")]
        [MinLength(5, ErrorMessage = "Wallet address is required and must be between 5 and 50 symbols!")]
        [MaxLength(50, ErrorMessage = "Wallet address is required and must be between 5 and 50 symbols!")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Provider is required!")]
        [RegularExpression("(^(?i)metamask|^coinbase|^walletconnect|^1$|^2$|^3$)",
            ErrorMessage = "Provider is not valid! Please type between \'1\' or \'metamask\' for metamask, \'2\' or \'coinbase\' for coinbase, \'3\' or \'walletconnect\' for walletconnect.")]
        public string Provider { get; set; }
    }
}
