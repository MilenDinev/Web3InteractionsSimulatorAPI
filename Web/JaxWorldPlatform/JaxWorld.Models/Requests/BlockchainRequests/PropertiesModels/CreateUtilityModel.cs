namespace JaxWorld.Models.Requests.BlockchainRequests.PropertiesModels
{
    using System.ComponentModel.DataAnnotations;
    using Base;
    using Constants;

    public class CreateUtilityModel : CreatePropertyModel
    {
        [Required(ErrorMessage = ValidationMessages.Required)]
        [StringLength(15, ErrorMessage = ValidationMessages.MinMaxLength, MinimumLength = 3)]
        public string? DisplayType { get; set; }
        public decimal Value { get; set; }
    }
}
