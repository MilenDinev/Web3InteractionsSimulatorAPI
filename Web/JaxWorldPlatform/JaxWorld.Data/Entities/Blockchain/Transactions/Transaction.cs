namespace JaxWorld.Data.Entities.Blockchain.Transactions
{
    using Contracts;
    using Blockchain.Wallets;
    using Interfaces.IEntities.IBlockchain.ITransactions;
    using JaxWorld.Data.Interfaces.IEntities.IBlockchain.ITransactions;

    public class Transaction : Entity, ITransaction
    {
        public string TxnHash { get; set; }
        public int StateId { get; set; }
        public virtual TransactionState State { get; set; }
        public virtual Wallet Creator { get; set; }
        public int ContractId { get; set; }
        public virtual Contract Contract { get; set; }
        public int NetworkId { get; set; }
        public virtual Network Network { get; set; }
    }
}
