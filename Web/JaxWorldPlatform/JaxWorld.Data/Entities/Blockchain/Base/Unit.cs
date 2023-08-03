namespace JaxWorld.Data.Entities.Blockchain.Base
{
    using Transactions;
    using Data.Interfaces.IEntities.IBlockchain.IBase;

    public abstract class Unit : Entity, IUnit
    {
        public Unit()
        {
            Transactions = new HashSet<Transaction>();
            Holders = new HashSet<UnitWalletBalance>();
        }

        public string Name { get; set; }
        public virtual ICollection<UnitWalletBalance> Holders { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}