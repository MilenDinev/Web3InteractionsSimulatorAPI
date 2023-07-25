namespace JaxWorld.Data.Interfaces.IEntities.IBlockchain.ITokens.IErc721.IUnits
{
    using Entities.Blockchain.Properties;

    public interface IErc721aUnit
    {
        string DNA { get; set; }
        ICollection<Attribute> Attributes { get; set; }
        ICollection<Utility> Utilities { get; set; }
    }
}
