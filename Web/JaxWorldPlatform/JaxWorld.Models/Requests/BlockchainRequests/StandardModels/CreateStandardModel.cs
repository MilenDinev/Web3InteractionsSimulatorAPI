using System.ComponentModel.DataAnnotations;

namespace JaxWorld.Models.Requests.BlockchainRequests.StandardModels
{
    public class CreateStandardModel
    {
        [Required]
        public string Name { get; set; }
    }
}
