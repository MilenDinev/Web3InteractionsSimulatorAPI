namespace JaxWorld.Models.Requests.BlockchainRequests.UnitModels
{
    using System.ComponentModel.DataAnnotations;
    using Constants;

    public class CreateErc721aUnitModel
    {
        [Required(ErrorMessage = ValidationMessages.Required)]
        [StringLength(AttributesParams.UnitNameMaxLength,
            ErrorMessage = ValidationMessages.MinMaxLength,
            MinimumLength = AttributesParams.UnitNameMinLength)]
        public string? Name { get; set; }
        public int ProfileId { get; set; }
        [StringLength(AttributesParams.DNAMaxLength,
            ErrorMessage = ValidationMessages.MinMaxLength,
            MinimumLength = AttributesParams.DNAMinLength)]
        public string? DNA { get; set; }
    }
}
