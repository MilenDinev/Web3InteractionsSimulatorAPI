namespace JaxWorld.Models.Requests.BlockchainRequests.ProfileModels
{
    using Constants;
    using System.ComponentModel.DataAnnotations;

    public class CreateProfileModel
    {
        [Required(ErrorMessage = ValidationMessages.Required)]
        [StringLength(AttributesParams.ProfileNameMaxLength,
            ErrorMessage = ValidationMessages.MinMaxLength,
            MinimumLength = AttributesParams.ProfileNameMinLength)]
        public string? Name { get; set; }

        [Required(ErrorMessage = ValidationMessages.Required)]
        [StringLength(AttributesParams.ProfileSymbolMaxLength,
            ErrorMessage = ValidationMessages.MinMaxLength,
            MinimumLength = AttributesParams.ProfileSymbolMinLength)]
        public string? Symbol { get; set; }

        [Required(ErrorMessage = ValidationMessages.Required)]
        [StringLength(AttributesParams.ProfileDescriptionMaxLength,
            ErrorMessage = ValidationMessages.MinMaxLength,
            MinimumLength = AttributesParams.ProfileDescriptionMinLength)]
        public string? Description { get; set; }

        [Required(ErrorMessage = ValidationMessages.Required)]
        public int TotalSupply { get; set; }

        [Required(ErrorMessage = ValidationMessages.Required)]
        [Range(1, int.MaxValue)]
        public int StandardId { get; set; }

        [Required(ErrorMessage = ValidationMessages.Required)]
        [Range(1, int.MaxValue)]
        public int ContractId { get; set; }
    }
}

