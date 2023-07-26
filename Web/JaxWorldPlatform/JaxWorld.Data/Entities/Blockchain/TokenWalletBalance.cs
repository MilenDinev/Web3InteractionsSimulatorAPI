namespace JaxWorld.Data.Entities.Blockchain
{
    using JaxWorld.Data.Entities.Blockchain.Base;
    using ProfileUnits.Base;
    using Wallets;

    public class TokenWalletBalance
    {
        public int TokenId { get; set; }
        public virtual Unit Token { get; set; }
        public int WalletId { get; set; }
        public virtual Wallet Wallet { get; set; }
        public decimal Balance { get; set; }
    }
}
