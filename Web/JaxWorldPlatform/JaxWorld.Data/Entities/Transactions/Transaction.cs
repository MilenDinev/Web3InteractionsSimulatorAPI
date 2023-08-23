namespace JaxWorld.Data.Entities.Transactions
{
    using Wallets;
    using Contracts;
    using Interfaces.IEntities.ITransactions;

    public class Transaction : Entity, ITransaction
    {
        public string TxnHash { get; set; }
        public int StateId { get; set; }
        public virtual TransactionState State { get; set; }
        public int NetworkId { get; set; }
        public virtual Network Network { get; set; }
        public int BlockId  { get; set; }
        public virtual Block Block  { get; set; }
        public DateTime Timestamp  { get; set; }
        public int InitiatorId { get; set; }
        public virtual Wallet Initiator { get; set; }
        public int TargetId { get; set; }
        public virtual Contract Target { get; set; }
        public int? OperationId { get; set; }
        public virtual TxnOperation Operation { get; set; }
        public decimal Value { get; set; }
        public decimal Fee { get; set; }
        public decimal GasPrice { get; set; }
        public decimal NativeValuePrice { get; set; }
        public int Nonce { get; set; }
        public ICollection<int> Logs { get; set; }
    }
}
