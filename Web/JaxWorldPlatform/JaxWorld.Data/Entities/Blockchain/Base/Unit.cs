namespace JaxWorld.Data.Entities.Blockchain.Base
{
    using Transactions;
    using Data.Interfaces.IEntities.IBlockchain.IBase;

    public abstract class Unit : Entity, IProfileUnit
    {
        public Unit()
        {
            Transactions = new HashSet<Transaction>();
            Holders = new HashSet<TokenWalletBalance>();
        }

        public string Name { get; set; }
        public virtual ICollection<TokenWalletBalance> Holders { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}