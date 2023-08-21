namespace JaxWorld.Models.Requests.BlockchainRequests.WalletModels
{
    using System.ComponentModel.DataAnnotations;
    using Constants;

    public class CreateWalletModel
    {
        [Required(ErrorMessage = ValidationMessages.Required)]
        [StringLength(50, ErrorMessage = ValidationMessages.MinMaxLength, MinimumLength = 5)]
        public string? Address { get; set; }
        [Required(ErrorMessage = ValidationMessages.Required)]
        [RegularExpression("(^(?i)metamask|^coinbase|^walletconnect|^1$|^2$|^3$)",
            ErrorMessage = ValidationMessages.Provider)]
        public string? Provider { get; set; }
    }
}

