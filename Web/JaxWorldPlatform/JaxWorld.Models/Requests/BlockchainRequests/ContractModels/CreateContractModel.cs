namespace JaxWorld.Models.Requests.BlockchainRequests.ContractModels
{
    using Constants;
    using System.ComponentModel.DataAnnotations;

    public class CreateContractModel
    {
        [Required(ErrorMessage = ValidationMessages.Required)]
        [StringLength(15, ErrorMessage = ValidationMessages.MinMaxLength, MinimumLength = 2)]
        public string Name { get; set; }

        [Required(ErrorMessage = ValidationMessages.Required)]
        [MinLength(5, ErrorMessage = ValidationMessages.MinLength)]
        public string ContractAddress { get; set; }

        [Required(ErrorMessage = ValidationMessages.Required)]
        [MinLength(5, ErrorMessage = ValidationMessages.MinLength)]
        public string CreatorAddress { get; set; }

        [Required(ErrorMessage = ValidationMessages.Required)]
        [MinLength(5, ErrorMessage = ValidationMessages.MinLength)]
        public string CreationTxnHash { get; set; }

        [RegularExpression("(^(?i)1$|^2$|^3$)",
            ErrorMessage = ValidationMessages.Network)]
        public int NetworkId { get; set; }
    }
}
