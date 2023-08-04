namespace JaxWorld.Models.Requests.BlockchainRequests.ContractModels
{
    using System.ComponentModel.DataAnnotations;

    public class EditContractModel
    {
        [Required]
        public string Name { get; set; }
    }
}
