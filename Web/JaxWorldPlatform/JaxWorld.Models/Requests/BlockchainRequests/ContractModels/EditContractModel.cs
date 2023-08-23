namespace JaxWorld.Models.Requests.BlockchainRequests.ContractModels
{
    using System.ComponentModel.DataAnnotations;
    using Constants;

    public class EditContractModel
    {
        [StringLength(AttributesParams.ContractNameMaxLength, 
            ErrorMessage = ValidationMessages.MinMaxLength, 
            MinimumLength = AttributesParams.ContractNameMinLength)]
        public string? Name { get; set; }
    }
}
