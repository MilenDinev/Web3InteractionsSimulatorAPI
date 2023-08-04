namespace JaxWorld.Data.Entities.Blockchain.Units
{
    using Base;
    using Wallets;
    using Profiles;
    using Properties;
    using Transactions;
    using Interfaces.IEntities.IBlockchain.IUnits;

    public class Erc721aUnit : Unit, IErc721aUnit
    {
        public Erc721aUnit()
        {
            Attributes = new HashSet<Attribute>();
            Utilities = new HashSet<Utility>();
            Transactions = new HashSet<Transaction>();
        }

        public string DNA { get; set; }
        public bool Minted { get; set; }
        public int MintedTxnId { get; set; }
        public virtual Transaction MintedTxn { get; set; }
        public int ProfileId { get; set; }
        public virtual Profile Profile { get; set; }
        public virtual ICollection<Attribute> Attributes { get; set; }
        public virtual ICollection<Utility> Utilities { get; set; }
        public int HolderId { get; set; }
        public virtual Wallet Holder { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}

