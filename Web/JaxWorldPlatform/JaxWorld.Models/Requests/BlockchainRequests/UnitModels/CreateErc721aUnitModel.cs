using System.ComponentModel.DataAnnotations;

namespace JaxWorld.Models.Requests.BlockchainRequests.UnitModels
{
    public class CreateErc721aUnitModel
    {
        [Required(ErrorMessage = "Unit name is required and must be between 2 and 15 symbols!")]
        [MaxLength(15, ErrorMessage = "Unit name is required and must be between 2 and 15 symbols!")]
        [MinLength(2, ErrorMessage = "Unit name is required and must be between 2 and 15 symbols!")]
        public string Name { get; set; }
        public int ProfileId { get; set; }
        public int MintedTxnId { get; set; }
        public string DNA { get; set; }
    }
}
