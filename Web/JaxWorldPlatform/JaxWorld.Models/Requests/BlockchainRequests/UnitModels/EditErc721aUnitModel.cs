namespace JaxWorld.Models.Requests.BlockchainRequests.UnitModels
{
    using System.ComponentModel.DataAnnotations;
    using Constants;

    public class EditErc721aUnitModel
    {
        [StringLength(15, ErrorMessage = ValidationMessages.MinMaxLength, MinimumLength = 2)]
        public string? Name { get; set; }

        [StringLength(30, ErrorMessage = ValidationMessages.MinMaxLength, MinimumLength = 5)]
        public string? DNA { get; set; }
    }
}
