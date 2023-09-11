namespace JaxWorld.Models.Requests.BlockchainRequests.ProfileModels
{
    using Constants;
    using System.ComponentModel.DataAnnotations;

    public class EditProfileModel
    {
        [StringLength(AttributesParams.ProfileDescriptionMaxLength,
            ErrorMessage = ValidationMessages.MinMaxLength,
            MinimumLength = AttributesParams.ProfileDescriptionMinLength)]
        public string? Description { get; set; }

        [Range(1, int.MaxValue)]
        public int? TotalSupply { get; set; }
    }
}
