namespace JaxWorld.Data.Entities.Blockchain.Tokens.Erc721.Units
{
    using Properties;
    using Tokens.Base;
    using Interfaces.IEntities.IBlockchain.ITokens.IErc721.IUnits;

    public class Erc721aUnit : ProfileUnit, IErc721aUnit
    {
        public Erc721aUnit()
        {
            Attributes = new HashSet<Attribute>();
            Utilities = new HashSet<Utility>();
        }

        public string DNA { get; set; }
        public bool Minted { get; set; }
        public virtual ICollection<Attribute> Attributes { get; set; }
        public virtual ICollection<Utility> Utilities { get; set; }
    }
}
