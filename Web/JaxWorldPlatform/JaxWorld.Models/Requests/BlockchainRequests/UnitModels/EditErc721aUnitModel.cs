namespace JaxWorld.Models.Requests.BlockchainRequests.UnitModels
{
    using System.ComponentModel.DataAnnotations;
    using Constants;

    public class EditErc721aUnitModel
    {
        [StringLength(AttributesParams.UnitNameMaxLength,
            ErrorMessage = ValidationMessages.MinMaxLength,
            MinimumLength = AttributesParams.UnitNameMinLength)]
        public string? Name { get; set; }

        [StringLength(AttributesParams.DNAMaxLength,
            ErrorMessage = ValidationMessages.MinMaxLength,
            MinimumLength = AttributesParams.DNAMinLength)]
        public string? DNA { get; set; }
    }
}
