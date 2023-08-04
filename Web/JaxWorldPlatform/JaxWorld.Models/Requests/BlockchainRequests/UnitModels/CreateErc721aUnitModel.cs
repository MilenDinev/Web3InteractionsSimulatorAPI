using System.ComponentModel.DataAnnotations;

namespace JaxWorld.Models.Requests.BlockchainRequests.UnitModels
{
    public class CreateErc721aUnitModel
    {
        [Required]
        public string Name { get; set; }
        public int ProfileId { get; set; }
        public int MintedTxnId { get; set; }
        public string DNA { get; set; }
    }
}
