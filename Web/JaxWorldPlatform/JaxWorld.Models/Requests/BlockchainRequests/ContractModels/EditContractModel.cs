namespace JaxWorld.Models.Requests.BlockchainRequests.ContractModels
{
    using System.ComponentModel.DataAnnotations;
    using Constants;

    public class EditContractModel
    {
        [StringLength(15, ErrorMessage = ValidationMessages.MinMaxLength, MinimumLength = 2)]
        public string? Name { get; set; }
    }
}
