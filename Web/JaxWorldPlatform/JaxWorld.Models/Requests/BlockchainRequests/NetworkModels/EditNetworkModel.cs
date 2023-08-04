namespace JaxWorld.Models.Requests.BlockchainRequests.NetworkModels
{
    public class EditNetworkModel
    {
        public string Name { get; init; }
        public string RpcUrl { get; init; }
        public string ChainId { get; init; }
        public string Symbol { get; init; }
        public string ExplorerUrl { get; init; }
    }
}
