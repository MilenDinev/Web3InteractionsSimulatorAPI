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
        public string Name { get; set; } = string.Empty;

        [RegularExpression("(^(?i)1$|^2$|^3$)",
            ErrorMessage = ValidationMessages.Network)]
        public int NetworkId { get; set; }
    }
}
