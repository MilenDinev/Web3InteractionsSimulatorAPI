namespace JaxWorld.Models.Requests.BlockchainRequests.UnitModels
{
    using System.ComponentModel.DataAnnotations;
    using Constants;

    public class CreateErc721aUnitModel
    {
        [Required(ErrorMessage = ValidationMessages.Required)]
        [StringLength(15, ErrorMessage = ValidationMessages.MinMaxLength, MinimumLength = 2)]
        public string? Name { get; set; }
        public int ProfileId { get; set; }
        [StringLength(30, ErrorMessage = ValidationMessages.MinMaxLength, MinimumLength = 5)]
        public string? DNA { get; set; }
    }
}
