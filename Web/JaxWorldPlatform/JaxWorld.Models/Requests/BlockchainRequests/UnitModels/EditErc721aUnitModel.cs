namespace JaxWorld.Models.Requests.BlockchainRequests.UnitModels
{
    using Constants;
    using System.ComponentModel.DataAnnotations;

    public class EditErc721aUnitModel
    {
        [StringLength(AttributesParams.UnitNameMaxLength,
            ErrorMessage = ValidationMessages.MinMaxLength,
            MinimumLength = AttributesParams.UnitNameMinLength)]
        public string? Name { get; set; }

    }
}
