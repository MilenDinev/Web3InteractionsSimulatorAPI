namespace JaxWorld.Models.Requests.BlockchainRequests.PropertiesModels.Base
{
    using Constants;
    using Interfaces;
    using System.ComponentModel.DataAnnotations;

    public abstract class CreatePropertyModel : ICreatePropertyModel
    {
        [Required(ErrorMessage = ValidationMessages.Required)]
        [StringLength(AttributesParams.TraitTypeMaxLength,
            ErrorMessage = ValidationMessages.MinMaxLength,
            MinimumLength = AttributesParams.TraitTypeMinLength)]
        public string? TraitType { get; set; }
    }
}

