namespace JaxWorld.Data.Entities.Blockchain
{
    using Wallets;
    using Contracts;
    using Transactions;
    using Interfaces.IEntities.IBlockchain;

    public class Network : INetwork
    {
        public Network()
        {
            Users = new HashSet<Wallet>();
            Contracts = new HashSet<Contract>();
            Transactions = new HashSet<Transaction>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string RpcUrl { get; set; }
        public string ChainId { get; set; }
        public string Symbol { get; set; }
        public string ExplorerUrl { get; set; }
        public virtual ICollection<Wallet> Users { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
        public virtual ICollection<Contract> Contracts { get; set; }
    }
}
