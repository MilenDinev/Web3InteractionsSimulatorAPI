namespace JaxWorld.Data.Interfaces.IBlockchain
{
    internal interface IChain
    {
        string Name { get; init; }
        string RpcUrl { get; init; }
        string ChainId { get; init; }
        string Symbol { get; init; }
        string ExplorerUrl { get; init; }
    }
}
