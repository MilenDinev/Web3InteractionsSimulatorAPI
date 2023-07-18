namespace JaxWorld.Data.Entities.Blockchain.Tokens.Erc721.Units
{
    using Base;
    using Properties;
    using Transactions;
    using Erc721.Profiles;
    using Interfaces.IEntities.IBlockchain.ITokens.IErc721.IUnits;

    public class Erc721aUnit : ProfileUnit, IErc721aUnit
    {
        public Erc721aUnit()
        {
            Attributes = new HashSet<Attribute>();
            Utilities = new HashSet<Utility>();
            Transactions = new HashSet<Transaction>();
            Holders = new HashSet<TokenWalletBalance>();
        }

        public string DNA { get; set; }
        public bool Minted { get; set; }
        public int ProfileId { get; set; }
        public virtual Erc721aProfile Profile { get; set; }
        public int MintedTxnId { get; set; }
        public virtual Transaction MintedTxn { get; set; }
        public virtual ICollection<TokenWalletBalance> Holders { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
        public virtual ICollection<Attribute> Attributes { get; set; }
        public virtual ICollection<Utility> Utilities { get; set; }
    }
}

