namespace JaxWorld.Models.Requests.BlockchainRequests.ChainModels
{
    internal class CreateChainModel
    {
        public string Name { get; init; }
        public string RpcUrl { get; init; }
        public string ChainId { get; init; }
        public string Symbol { get; init; }
        public string ExplorerUrl { get; init; }
    }
}
