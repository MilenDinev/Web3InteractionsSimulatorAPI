namespace JaxWorld.Data.Blockchain.Tokens.Base
{
    using Wallets;
    using Contracts;
    using Transactions;
    using Interfaces.IBlockchain.ITokens.IBase;

    public abstract class ContractProfile : IProfile
    {
        public ContractProfile()
        {
            this.Holders = new HashSet<Wallet>();
            this.Transactions = new HashSet<Transaction>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public int StandardId { get; set; }
        public Standard Standard { get; set; }
        public int ContractId { get; set; }
        public virtual Contract Contract { get; set; }
        public virtual ICollection<ProfileUnit> Units { get; set; }
        public virtual ICollection<Wallet> Holders { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }

    }
}
