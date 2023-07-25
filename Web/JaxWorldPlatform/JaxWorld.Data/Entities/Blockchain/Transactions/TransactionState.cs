namespace JaxWorld.Data.Entities.Blockchain.Transactions
{
    using Interfaces.IEntities.IBlockchain.ITransactions;
    using JaxWorld.Data.Interfaces.IEntities.IBlockchain.ITransactions;

    public class TransactionState : Entity, IState
    {
        public TransactionState()
        {
            Transactions = new HashSet<Transaction>();
        }
        public string Value { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
