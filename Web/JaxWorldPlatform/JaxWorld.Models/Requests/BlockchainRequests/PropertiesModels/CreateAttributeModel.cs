namespace JaxWorld.Models.Requests.BlockchainRequests.PropertiesModels
{
    using System.ComponentModel.DataAnnotations;
    using Base;
    using Constants;

    public class CreateAttributeModel : CreatePropertyModel
    {
        [Required(ErrorMessage = ValidationMessages.Required)]
        [StringLength(15, ErrorMessage = ValidationMessages.MinMaxLength, MinimumLength = 3)]
        public string? Value { get; set; }
    }
}
