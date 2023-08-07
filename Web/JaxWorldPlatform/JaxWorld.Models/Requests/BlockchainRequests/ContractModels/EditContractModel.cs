namespace JaxWorld.Models.Requests.BlockchainRequests.ContractModels
{
    using System.ComponentModel.DataAnnotations;

    public class EditContractModel
    {
        [MinLength(2, ErrorMessage = "Contract must be between 2 and 15 symbols!")]
        [MaxLength(15, ErrorMessage = "Contract must be between 2 and 15 symbols!")]
        public string? Name { get; set; }
    }
}
