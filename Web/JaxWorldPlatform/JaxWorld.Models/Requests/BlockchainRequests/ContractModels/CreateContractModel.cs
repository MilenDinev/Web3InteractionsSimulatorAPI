namespace JaxWorld.Models.Requests.BlockchainRequests.ContractModels
{
    using System.ComponentModel.DataAnnotations;

    public class CreateContractModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        public int ChainId { get; set; }
    }
}
