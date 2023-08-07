namespace JaxWorld.Models.Requests.BlockchainRequests.ProfileModels
{
    using System.ComponentModel.DataAnnotations;

    public class EditProfileModel
    {
        [MinLength(2, ErrorMessage = "Name must be between 2 and 10 symbols!")]
        [MaxLength(15, ErrorMessage = "Name must be between 2 and 10 symbols!")]
        public string Name { get; set; }

        [MinLength(1, ErrorMessage = "Symbol must be between 1 and 5 symbols!")]
        [MaxLength(5, ErrorMessage = "Symbol must be between 1 and 5 symbols!")]
        public string Symbol { get; set; }

        [MinLength(10, ErrorMessage = "Description must be between 10 and 50 symbols!")]
        [MaxLength(50, ErrorMessage = "Description must be between 10 and 50 symbols!")]
        public string Description { get; set; }
        public int? TotalSupply { get; set; }
    }
}
