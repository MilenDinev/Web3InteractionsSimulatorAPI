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

        public int Id { get; init; }
        public string Name { get; init; }
        public string RpcUrl { get; init; }
        public string ChainId { get; init; }
        public string Symbol { get; init; }
        public string ExplorerUrl { get; init; }
        public virtual ICollection<Wallet> Users { get; set; }
        public virtual ICollection<Transaction> Transactions { get; }
        public virtual ICollection<Contract> Contracts { get; }
    }
}
