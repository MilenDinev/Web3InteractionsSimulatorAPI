using System.ComponentModel.DataAnnotations;

namespace JaxWorld.Models.Requests.BlockchainRequests.TransactionModels
{
    public class DeployContractModel
    {
        [Range(1, int.MaxValue)]
        public int NetworkId { get; set; }
        public string? TargetContract { get; set; }
        public string? InitiatorWallet { get; set; }
    }
}
