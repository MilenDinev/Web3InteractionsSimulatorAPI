namespace JaxWorld.Data.Entities.Transactions
{
    using Interfaces.IEntities.ITransactions;

    public class TransactionState : Entity, IState
    {
        public TransactionState()
        {
            Transactions = new HashSet<Transaction>();
        }
        public string State { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
