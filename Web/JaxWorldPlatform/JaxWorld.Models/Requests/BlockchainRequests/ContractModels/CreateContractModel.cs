namespace JaxWorld.Models.Requests.BlockchainRequests.ContractModels
{
    using System.ComponentModel.DataAnnotations;

    public class CreateContractModel
    {
        [Required(ErrorMessage = "Name!")]
        [MinLength(2, ErrorMessage = "Name must be between 2 and 15 symbols!")]
        [MaxLength(15, ErrorMessage = "Name must be between 2 and 15 symbols!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Address is required!")]
        [MinLength(5, ErrorMessage = "Address must be atleast 5 symbols!")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Network is required!")]
        [RegularExpression("(^(?i)1$|^2$|^3$)",
            ErrorMessage = "Network is not valid! Please type between \'1\' for Avalanche Mainnet Network and \'2\' for Avalanche FUJI C-Chain.")]
        public int NetworkId { get; set; }
    }
}
