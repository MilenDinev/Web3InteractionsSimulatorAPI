namespace JaxWorld.Data.Entities.Transactions
{
    using Constants;
    using Contracts;
    using Microsoft.EntityFrameworkCore;
    using Wallets;

    public class Transaction : Entity
    {
        public Transaction()
        {
            this.Logs = new HashSet<TxnLog>();
        }

        public string TxnHash { get; set; }
        public int StateId { get; set; }
        public virtual TransactionState State { get; set; }
        public int NetworkId { get; set; }
        public virtual Network Network { get; set; }
        public int BlockId { get; set; }
        public virtual Block Block { get; set; }
        public DateTime Timestamp { get; set; }
        public int InitiatorId { get; set; }
        public virtual Wallet Initiator { get; set; }
        public int? TargetId { get; set; }
        public virtual Contract Target { get; set; }
        public int? TxnActionId { get; set; }
        public virtual TxnAction TxnAction { get; set; }
        [Precision(AttributesParams.DecimalPrecision, AttributesParams.DecimalScale)]
        public decimal Value { get; set; }
        [Precision(AttributesParams.DecimalPrecision, AttributesParams.DecimalScale)]
        public decimal Fee { get; set; }
        [Precision(AttributesParams.DecimalPrecision, AttributesParams.DecimalScale)]
        public decimal GasPrice { get; set; }
        [Precision(AttributesParams.DecimalPrecision, AttributesParams.DecimalScale)]
        public decimal NativeValuePrice { get; set; }
        public int Nonce { get; set; }
        public virtual ICollection<TxnLog> Logs { get; set; }
    }
}
