namespace JaxWorld.Models.Requests.BlockchainRequests.ContractModels
{
    using Constants;
    using System.ComponentModel.DataAnnotations;

    public class EditContractModel
    {
        [StringLength(AttributesParams.ContractNameMaxLength,
            ErrorMessage = ValidationMessages.MinMaxLength,
            MinimumLength = AttributesParams.ContractNameMinLength)]
        public string? Name { get; set; }
    }
}
