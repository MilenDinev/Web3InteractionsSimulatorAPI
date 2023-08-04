namespace JaxWorld.Models.Requests.BlockchainRequests.ProfileModels
{
    using System.ComponentModel.DataAnnotations;

    public class CreateProfileModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Symbol { get; set; }
        [Required]
        public string Description { get; set; }
        public int TotalSupply { get; set; }
        public int StandardId { get; set; }
        public int ContractId { get; set; }
    }
}
