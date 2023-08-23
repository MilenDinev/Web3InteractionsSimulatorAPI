namespace JaxWorld.Models.Requests.BlockchainRequests.ProfileModels
{
    using System.ComponentModel.DataAnnotations;
    using Constants;

    public class EditProfileModel
    {
        [StringLength(AttributesParams.ProfileNameMaxLength,
            ErrorMessage = ValidationMessages.MinMaxLength,
            MinimumLength = AttributesParams.ProfileNameMinLength)]
        public string? Name { get; set; }

        [StringLength(AttributesParams.ProfileSymbolMaxLength,
            ErrorMessage = ValidationMessages.MinMaxLength,
            MinimumLength = AttributesParams.ProfileSymbolMinLength)]
        public string? Symbol { get; set; }

        [StringLength(AttributesParams.ProfileDescriptionMaxLength,
            ErrorMessage = ValidationMessages.MinMaxLength,
            MinimumLength = AttributesParams.ProfileDescriptionMinLength)]
        public string? Description { get; set; }
        public int? TotalSupply { get; set; }
    }
}
