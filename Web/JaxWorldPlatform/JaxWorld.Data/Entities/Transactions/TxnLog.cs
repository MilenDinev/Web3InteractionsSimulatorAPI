namespace JaxWorld.Data.Entities.Transactions
{
    using Base;
    using Entities;

    public class TxnLog : Entity
    {
        public TxnLog()
        {
            this.Topics = new HashSet<TxnTopic>();
        }
        public int ContractId { get; set; }
        public virtual Contract Contract { get; set; }
        public int TxnMethodId { get; set; }
        public virtual TxnMethod TxnMethod { get; set; }
        public int TxnDataId { get; set; }
        public virtual TxnData TxnData { get; set; }
        public virtual ICollection<TxnTopic> Topics { get; set; }
    }
}
