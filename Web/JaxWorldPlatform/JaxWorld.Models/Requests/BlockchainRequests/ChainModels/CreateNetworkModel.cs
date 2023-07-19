namespace JaxWorld.Models.Requests.BlockchainRequests.ChainModels
{
    public class CreateNetworkModel
    {
        public string Name { get; init; }
        public string RpcUrl { get; init; }
        public string NetworkId { get; init; }
        public string Symbol { get; init; }
        public string ExplorerUrl { get; init; }
    }
}
