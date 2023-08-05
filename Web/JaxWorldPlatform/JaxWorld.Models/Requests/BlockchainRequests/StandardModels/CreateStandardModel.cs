using System.ComponentModel.DataAnnotations;

namespace JaxWorld.Models.Requests.BlockchainRequests.StandardModels
{
    public class CreateStandardModel
    {
        [Required(ErrorMessage = "Standard name is required and must be between 2 and 15 symbols!")]
        [MaxLength(15, ErrorMessage = "Standard name is required and must be between 2 and 15 symbols!")]
        [MinLength(2, ErrorMessage = "Standard name is required and must be between 2 and 15 symbols!")]
        public string Name { get; set; }
    }
}
