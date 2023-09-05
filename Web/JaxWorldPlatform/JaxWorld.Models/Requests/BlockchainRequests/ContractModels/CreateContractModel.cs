namespace JaxWorld.Models.Requests.BlockchainRequests.ContractModels
{
    using Constants;
    using System.ComponentModel.DataAnnotations;

    public class CreateContractModel
    {
        [Required(ErrorMessage = ValidationMessages.Required)]
        [StringLength(AttributesParams.ContractNameMaxLength, 
            ErrorMessage = ValidationMessages.MinMaxLength, 
            MinimumLength = AttributesParams.ContractNameMinLength)]
        public string Name { get; set; }

        [Required(ErrorMessage = ValidationMessages.Required)]
        [MinLength(AttributesParams.ContractAddressMinLength, 
            ErrorMessage = ValidationMessages.MinLength)]
        public string ContractAddress { get; set; }

        [Required(ErrorMessage = ValidationMessages.Required)]
        [MinLength(AttributesParams.WalletAddressMinLength, 
            ErrorMessage = ValidationMessages.MinLength)]
        public string CreatorAddress { get; set; }

        [Required(ErrorMessage = ValidationMessages.Required)]
        [MinLength(AttributesParams.TxnHashMinLength, 
            ErrorMessage = ValidationMessages.MinLength)]
        public string CreationTxnHash { get; set; }

        [RegularExpression("(^(?i)1$|^2$|^3$)",
            ErrorMessage = ValidationMessages.Network)]
        public int NetworkId { get; set; }
    }
}
