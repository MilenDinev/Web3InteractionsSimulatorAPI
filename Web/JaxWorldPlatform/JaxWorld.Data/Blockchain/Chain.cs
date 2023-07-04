namespace JaxWorld.Data.Blockchain
{
    using Wallets;
    using Contracts;
    using Transactions;
    using Interfaces.IBlockchain;

    public class Chain : IChain
    {
        public Chain()
        {
            Users = new HashSet<Wallet>();
            Contracts = new HashSet<Contract>();
            Transactions = new HashSet<Transaction>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Wallet> Users { get; set; }
        public virtual ICollection<Transaction> Transactions { get; }
        public virtual ICollection<Contract> Contracts { get; }
    }
}
