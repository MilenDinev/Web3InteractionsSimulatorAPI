namespace JaxWorld.Data.Blockchain.Transactions
{
    using Wallets;
    using Contracts;
    using Interfaces.IBlockchain.ITransactions;

    public class Transaction : ITransaction
    {
        public int Id { get; set; }
        public string TxnHash { get; set; }
        public DateTime CreatedOn { get; set; }

        public int StateId { get; set; }
        public virtual TransactionState State { get; set; }
        public int CreatorId { get; set; }
        public virtual Wallet Creator { get; set; }
        public int ContractId { get; set; }
        public virtual Contract Contract { get; set; }
        public int ChainId { get; set; }
        public virtual Chain Chain { get; set; }
    }
}
