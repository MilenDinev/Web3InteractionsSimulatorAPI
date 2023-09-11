namespace JaxWorld.Models.Requests.BlockchainRequests.UnitModels
{
    using Constants;
    using System.ComponentModel.DataAnnotations;

    public class CreateErc721aUnitModel
    {
        [Required(ErrorMessage = ValidationMessages.Required)]
        [StringLength(AttributesParams.UnitNameMaxLength,
            ErrorMessage = ValidationMessages.MinMaxLength,
            MinimumLength = AttributesParams.UnitNameMinLength)]
        public string Name { get; set; }

        [Required(ErrorMessage = ValidationMessages.Required)]
        [StringLength(AttributesParams.ProfileDescriptionMaxLength,
    ErrorMessage = ValidationMessages.MinMaxLength,
    MinimumLength = AttributesParams.ProfileDescriptionMinLength)]
        public string Description { get; set; }

        [Range(1, int.MaxValue)]
        public int ProfileId { get; set; }
    }
}
