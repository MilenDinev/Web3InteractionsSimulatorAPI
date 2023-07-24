namespace JaxWorld.Data.Entities.Blockchain.Wallets
{
    using Entities;
    using Contracts;
    using Transactions;
    using Interfaces.IEntities.IBlockchain.IWallets;

    public class Wallet : Entity, IWallet
    {
        public Wallet()
        {
            Chains = new HashSet<Network>();
            Transactions = new HashSet<Transaction>();
            CreatedContracts = new HashSet<Contract>();
            Tokens = new HashSet<TokenWalletBalance>();
        }

        public string Address { get; set; }
        public decimal Balance { get; set; }
        public int OwnerId { get; set; }
        public virtual User Owner { get; set; }
        public int ProviderId { get; set; }
        public virtual Provider Provider { get; set; }

        public virtual ICollection<Network> Chains { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
        public virtual ICollection<Contract> CreatedContracts { get; set; }
        public virtual ICollection<TokenWalletBalance> Tokens { get; set; }
    }
}
