namespace JaxWorld.Models.Requests.BlockchainRequests.PropertiesModels
{
    using System.ComponentModel.DataAnnotations;
    using Base;
    using Constants;

    public class CreateUtilityModel : CreatePropertyModel
    {
        [Required(ErrorMessage = ValidationMessages.Required)]
        [StringLength(AttributesParams.DisplayTypeMaxLength,
            ErrorMessage = ValidationMessages.MinMaxLength,
            MinimumLength = AttributesParams.DisplayTypeMinLength)]
        public string? DisplayType { get; set; }
        public decimal Value { get; set; }
    }
}
