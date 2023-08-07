namespace JaxWorld.Models.Requests.BlockchainRequests.ProfileModels
{
    using System.ComponentModel.DataAnnotations;

    public class CreateProfileModel
    {
        [Required(ErrorMessage = "Name is required!")]
        [MinLength(2, ErrorMessage = "Name must be between 2 and 10 symbols!")]
        [MaxLength(15, ErrorMessage = "Name must be between 2 and 10 symbols!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Symbol is required!")]
        [MinLength(1, ErrorMessage = "Symbol must be between 1 and 5 symbols!")]
        [MaxLength(5, ErrorMessage = "Symbol must be between 1 and 5 symbols!")]
        public string Symbol { get; set; }

        [Required(ErrorMessage = "Description is required!")]
        [MinLength(10, ErrorMessage = "Description must be between 10 and 50 symbols!")]
        [MaxLength(50, ErrorMessage = "Description must be between 10 and 50 symbols!")]
        public string Description { get; set; }
        public int TotalSupply { get; set; }
        public int StandardId { get; set; }
        public int ContractId { get; set; }
    }
}
