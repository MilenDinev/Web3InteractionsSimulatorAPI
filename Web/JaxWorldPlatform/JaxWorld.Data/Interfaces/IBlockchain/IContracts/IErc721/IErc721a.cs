namespace JaxWorld.Data.Interfaces.IBlockchain.IContracts.IErc721
{
    public interface IErc721a
    {
        string Symbol { get; set; }
        string Description { get; set; }
        int TotalSupply { get; set; }
        int TotalMinted { get; set; }
        bool IsSupplyCap { get; set; }
    }
}
