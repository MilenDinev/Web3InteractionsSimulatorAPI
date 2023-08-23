namespace JaxWorld.Models.Requests.BlockchainRequests.PropertiesModels
{
    using System.ComponentModel.DataAnnotations;
    using Base;
    using Constants;

    public class CreateAttributeModel : CreatePropertyModel
    {
        [Required(ErrorMessage = ValidationMessages.Required)]
        [StringLength(AttributesParams.ValueMaxLength,
            ErrorMessage = ValidationMessages.MinMaxLength,
            MinimumLength = AttributesParams.ValueMinLength)]
        public string? Value { get; set; }
    }
}
