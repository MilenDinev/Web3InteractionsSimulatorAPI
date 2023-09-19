namespace JaxWorld.Data.Entities.Transactions
{
    public class TxnAction : Entity
    {
        public TxnAction()
        {
            this.Transactions = new HashSet<Transaction>();
        }

        public string Operation { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
