namespace JaxWorld.Models.Requests.BlockchainRequests.UnitModels
{
    using System.ComponentModel.DataAnnotations;

    public class EditErc721aUnitModel
    {
        [Required(ErrorMessage = "Name is required!")]
        [MinLength(2, ErrorMessage = "Name must be between 2 and 15 symbols!")]
        [MaxLength(15, ErrorMessage = "Name must be between 2 and 15 symbols!")]
        public string Name { get; set; }

        [MinLength(5, ErrorMessage = "DNA must be between 5 and 25 symbols!")]
        [MaxLength(25, ErrorMessage = "DNA must be between 5 and 25 symbols!")]
        public string? DNA { get; set; }
    }
}
