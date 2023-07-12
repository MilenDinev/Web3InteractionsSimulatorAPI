namespace JaxWorld.Data.Blockchain.Tokens.Erc721.Units
{
    using Wallets;
    using Properties;
    using Tokens.Base;
    using Interfaces.IBlockchain.ITokens.IErc721.IUnits;

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
