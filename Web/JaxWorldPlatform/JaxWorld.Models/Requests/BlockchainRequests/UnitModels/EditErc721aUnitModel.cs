namespace JaxWorld.Models.Requests.BlockchainRequests.UnitModels
{
    using System.ComponentModel.DataAnnotations;

    public class EditErc721aUnitModel
    {
        [MinLength(2, ErrorMessage = "Name must be between 2 and 15 symbols!")]
        [MaxLength(15, ErrorMessage = "Name must be between 2 and 15 symbols!")]
        public string? Name { get; set; }

        [MinLength(5, ErrorMessage = "DNA must be between 5 and 45 symbols!")]
        [MaxLength(45, ErrorMessage = "DNA must be between 5 and 45 symbols!")]
        public string? DNA { get; set; }
    }
}
