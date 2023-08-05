namespace JaxWorld.Models.Requests.BlockchainRequests.ProfileModels
{
    using System.ComponentModel.DataAnnotations;

    public class CreateProfileModel
    {
        [Required(ErrorMessage = "Profile name is required and must be between 21 and 15 symbols!")]
        [MaxLength(15, ErrorMessage = "Profile name is required and must be between 2 and 10 symbols!")]
        [MinLength(2, ErrorMessage = "Profile name is required and must be between 2 and 10 symbols!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Profile symbol is required and must be between 1 and 5 symbols!")]
        [MaxLength(5, ErrorMessage = "Profile symbol is required and must be between 1 and 5 symbols!")]
        [MinLength(1, ErrorMessage = "Profile symbol is required and must be between 1 and 5 symbols!")]
        public string Symbol { get; set; }

        [Required(ErrorMessage = "Profile description is required and must be between 10 and 50 symbols!")]
        [MaxLength(50, ErrorMessage = "Profile description is required and must be between 10 and 50 symbols!")]
        [MinLength(10, ErrorMessage = "Profile description is required and must be between 10 and 50 symbols!")]
        public string Description { get; set; }
        public int TotalSupply { get; set; }
        public int StandardId { get; set; }
        public int ContractId { get; set; }
    }
}
