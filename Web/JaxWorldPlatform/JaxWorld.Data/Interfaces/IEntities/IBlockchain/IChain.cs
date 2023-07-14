namespace JaxWorld.Data.Interfaces.IEntities.IBlockchain
{
    internal interface IChain
    {
        string Name { get; set; }
        string RpcUrl { get; set; }
        string NetworkId { get; set; }
        string Symbol { get; set; }
        string ExplorerUrl { get; set; }
    }
}
