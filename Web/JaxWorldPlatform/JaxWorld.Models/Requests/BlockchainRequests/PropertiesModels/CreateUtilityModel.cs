namespace JaxWorld.Models.Requests.BlockchainRequests.PropertiesModels
{
    using Base;
    using Constants;
    using System.ComponentModel.DataAnnotations;

    public class CreateUtilityModel : CreatePropertyModel
    {
        [Required(ErrorMessage = ValidationMessages.Required)]
        [StringLength(AttributesParams.DisplayTypeMaxLength,
            ErrorMessage = ValidationMessages.MinMaxLength,
            MinimumLength = AttributesParams.DisplayTypeMinLength)]
        public string? DisplayType { get; set; }

        [Required(ErrorMessage = ValidationMessages.Required)]
        public decimal? Value { get; set; }
    }
}
