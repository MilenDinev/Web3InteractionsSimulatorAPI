namespace JaxWorld.Data.Blockchain.Wallets
{
    using Tokens;
    using Entities;
    using Contracts;
    using Transactions;
    using Interfaces.IBlockchain.IWallets;

    public class Wallet : IWallet
    {
        public Wallet()
        {
            Chains = new HashSet<Chain>();
            Transactions = new HashSet<Transaction>();
            Tokens = new HashSet<TokenWalletBalance>();
            ContractsOwned = new HashSet<Contract>();
            ContractsCreated = new HashSet<Contract>();
            ContractsApproved = new HashSet<Contract>();
        }

        public string Address { get; set; }
        public decimal Balance { get; set; }
        public int OwnerId { get; set; }
        public virtual User Owner { get; set; }
        public int ProviderId { get; set; }
        public virtual Provider Provider { get; set; }

        public virtual ICollection<Chain> Chains { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
        public virtual ICollection<Contract> ContractsOwned { get; set; }
        public virtual ICollection<Contract> ContractsCreated { get; set; }
        public virtual ICollection<Contract> ContractsApproved { get; set; }
        public virtual ICollection<TokenWalletBalance> Tokens { get; set; }
    }
}
