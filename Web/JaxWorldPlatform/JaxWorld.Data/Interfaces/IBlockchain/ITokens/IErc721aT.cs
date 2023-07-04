namespace JaxWorld.Data.Interfaces.IBlockchain.ITokens
{
    using Blockchain.Properties;

    public interface IErc721aT
    {
        string DNA { get; set; }
        ICollection<Attribute> Attributes { get; set; }
        ICollection<Utility> Utilities { get; set; }
    }
}
