namespace JaxWorld.Data.Blockchain.Tokens
{
    using Wallets;
    using Contracts;
    using Transactions;
    using Interfaces.IBlockchain.ITokens;

    public abstract class Token : IToken
    {
        public Token()
        {
            Holders = new HashSet<TokenWalletBalance>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string ExternalUrl { get; set; }
        public decimal Price { get; set; }
        public int ContractId { get; set; }
        public virtual Contract Contract { get; set; }
        public int MintedTxnId { get; set; }
        public virtual Transaction MintedTxn { get; set; }
        public int MinterId { get; set; }
        public virtual Wallet Minter { get; set; }
        public virtual ICollection<TokenWalletBalance> Holders { get; set; }

    }
}
