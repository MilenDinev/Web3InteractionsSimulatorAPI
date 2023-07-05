namespace JaxWorld.Data.Blockchain.Contracts
{
    using Wallets;
    using Transactions;
    using Interfaces.IBlockchain.IContracts;

    public abstract class Contract : IContract
    {
        public Contract()
        {
            ApprovedByWallets = new HashSet<Wallet>();
            Transactions = new HashSet<Transaction>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int StandardId { get; set; }
        public virtual Standard Standard { get; set; }
        public int CreatedTxnId { get; set; }
        public int CreatorId { get; set; }
        public DateTime CreatedOn { get; set; }
        public virtual Wallet Creator { get; set; }
        public int LastModifierId { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public int OwnerId { get; set; }
        public virtual Wallet Owner { get; set; }
        public int ChainId { get; set; }
        public virtual Chain Chain { get; set; }
        public virtual ICollection<Wallet> ApprovedByWallets { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
