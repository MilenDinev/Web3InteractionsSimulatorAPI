namespace JaxWorld.Data.Blockchain.Tokens
{
    using Wallets;
    public class TokenWalletBalance
    {

        public int TokenId { get; set; }
        public Token Token { get; set; }
        public int WalletId { get; set; }
        public Wallet Wallet { get; set; }
        public decimal Balance { get; set; }
    }
}
