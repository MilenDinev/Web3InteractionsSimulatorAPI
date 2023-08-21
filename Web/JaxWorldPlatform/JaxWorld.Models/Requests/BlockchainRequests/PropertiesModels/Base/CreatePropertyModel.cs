namespace JaxWorld.Models.Requests.BlockchainRequests.PropertiesModels.Base
{
    using System.ComponentModel.DataAnnotations;
    using Constants;
    using Interfaces;

    public abstract class CreatePropertyModel : ICreatePropertyModel
    {
        [Required(ErrorMessage = ValidationMessages.Required)]
        [StringLength(15, ErrorMessage = ValidationMessages.MinMaxLength, MinimumLength = 3)]
        public string? TraitType { get; set; }
    }
}

