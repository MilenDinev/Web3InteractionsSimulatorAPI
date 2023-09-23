namespace JaxWorld.Data.Entities.Transactions
{
    using Base;

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
