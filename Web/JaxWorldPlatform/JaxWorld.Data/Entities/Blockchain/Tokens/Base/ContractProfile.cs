namespace JaxWorld.Data.Entities.Blockchain.Tokens.Base
{
    using Tokens;
    using Wallets;
    using Contracts;
    using Transactions;
    using Interfaces.IEntities.IBlockchain.ITokens.IBase;

    public abstract class ContractProfile : IContractProfile
    {
        public ContractProfile()
        {
            Holders = new HashSet<Wallet>();
            Transactions = new HashSet<Transaction>();
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
