namespace JaxWorld.Data.Entities.Blockchain.Units
{
    using Base;
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
        }

        public string DNA { get; set; }
        public bool Minted { get; set; }
        public int ProfileId { get; set; }
        public virtual Erc721aProfile Profile { get; set; }
        public int MintedTxnId { get; set; }
        public virtual Transaction MintedTxn { get; set; }
        public virtual ICollection<Attribute> Attributes { get; set; }
        public virtual ICollection<Utility> Utilities { get; set; }
    }
}

