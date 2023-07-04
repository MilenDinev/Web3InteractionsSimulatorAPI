namespace JaxWorld.Data.Blockchain.Transactions
{
    using Interfaces.IBlockchain.ITransactions;

    public class TransactionState : IState
    {
        public TransactionState()
        {
            Transactions = new HashSet<Transaction>();
        }
        public int Id { get; set; }
        public string Value { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
