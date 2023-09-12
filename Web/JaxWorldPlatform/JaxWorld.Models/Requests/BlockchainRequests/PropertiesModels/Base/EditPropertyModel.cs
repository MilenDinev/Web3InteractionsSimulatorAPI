namespace JaxWorld.Models.Requests.BlockchainRequests.PropertiesModels.Base
{
    using System.ComponentModel.DataAnnotations;
    using Constants;

    public abstract class EditPropertyModel 
    {
        [StringLength(AttributesParams.TraitTypeMaxLength,
            ErrorMessage = ValidationMessages.MinMaxLength,
            MinimumLength = AttributesParams.TraitTypeMinLength)]
        public string? TraitType { get; set; }
    }
}
