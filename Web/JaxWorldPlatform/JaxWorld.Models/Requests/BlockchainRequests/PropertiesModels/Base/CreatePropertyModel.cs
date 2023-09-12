namespace JaxWorld.Models.Requests.BlockchainRequests.PropertiesModels.Base
{
    using Constants;
    using System.ComponentModel.DataAnnotations;

    public abstract class CreatePropertyModel
    {
        [Required(ErrorMessage = ValidationMessages.Required)]
        [StringLength(AttributesParams.TraitTypeMaxLength,
            ErrorMessage = ValidationMessages.MinMaxLength,
            MinimumLength = AttributesParams.TraitTypeMinLength)]
        public string? TraitType { get; set; }
    }
}

