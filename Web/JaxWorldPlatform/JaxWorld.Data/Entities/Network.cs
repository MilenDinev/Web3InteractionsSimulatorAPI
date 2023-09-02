namespace JaxWorld.Data.Entities
{
    using Wallets;
    using Contracts;
    using Transactions;

    public class Network : Entity
    {
        public Network()
        {
            Wallets = new HashSet<Wallet>();
            Contracts = new HashSet<Contract>();
            Transactions = new HashSet<Transaction>();
            Blocks = new HashSet<Block>();
        }

        public string Name { get; set; }
        public string RpcUrl { get; set; }
        public string ChainId { get; set; }
        public string Symbol { get; set; }
        public string? ExplorerUrl { get; set; }
        public virtual ICollection<Wallet> Wallets { get; set; }
        public virtual ICollection<Block> Blocks { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
        public virtual ICollection<Contract> Contracts { get; set; }
    }
}
