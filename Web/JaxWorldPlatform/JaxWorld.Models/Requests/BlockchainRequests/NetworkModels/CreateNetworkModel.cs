namespace JaxWorld.Models.Requests.BlockchainRequests.NetworkModels
{
    using System.ComponentModel.DataAnnotations;

    public class CreateNetworkModel
    {
        [Required]
        public string Name { get; init; }
        [Required]
        public string Symbol { get; init; }
        [Required]
        public string RpcUrl { get; init; }
        public int ChainId { get; init; }
        public string ExplorerUrl { get; init; }
    }
}
