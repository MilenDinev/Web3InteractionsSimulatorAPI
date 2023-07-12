namespace JaxWorld.Data.Blockchain.Tokens
{
    using Base;
    using Wallets;

    public class TokenWalletBalance
    {

        public int TokenId { get; set; }
        public virtual ProfileUnit Token { get; set; }
        public int WalletId { get; set; }
        public virtual Wallet Wallet { get; set; }
        public decimal Balance { get; set; }
    }
}
