namespace JaxWorld.Models.Requests.BlockchainRequests.ProfileModels
{
    using System.ComponentModel.DataAnnotations;
    using Constants;

    public class EditProfileModel
    {
        [StringLength(15, ErrorMessage = ValidationMessages.MinMaxLength, MinimumLength = 2)]
        public string? Name { get; set; }

        [StringLength(5, ErrorMessage = ValidationMessages.MinMaxLength, MinimumLength = 1)]
        public string? Symbol { get; set; }

        [StringLength(50, ErrorMessage = ValidationMessages.MinMaxLength, MinimumLength = 10)]
        public string? Description { get; set; }
        public int? TotalSupply { get; set; }
    }
}
