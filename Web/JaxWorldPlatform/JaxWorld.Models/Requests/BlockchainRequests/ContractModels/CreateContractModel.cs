namespace JaxWorld.Models.Requests.BlockchainRequests.ContractModels
{
    using System.ComponentModel.DataAnnotations;

    public class CreateContractModel
    {
        [Required(ErrorMessage = "Contract name is required and must be between 2 and 15 symbols!")]
        [MaxLength(15, ErrorMessage = "Contract name is required and must be between 2 and 15 symbols!")]
        [MinLength(2, ErrorMessage = "Contract name is required and must be between 2 and 15 symbols!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Contract address is required and must be more than 5 symbols!")]
        [MinLength(5, ErrorMessage = "Contract address is required and must be more than 5 symbols!")]
        public string Address { get; set; }
        public int ChainId { get; set; }
    }
}
