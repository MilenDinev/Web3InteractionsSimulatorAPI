namespace JaxWorld.Data.Entities.Blockchain
{
    using Base;
    using Wallets;

    public class UnitWalletBalance
    {
        public int Id { get; set; }
        public int UnitId { get; set; }
        public virtual Unit Unit { get; set; }
        public int WalletId { get; set; }
        public virtual Wallet Wallet { get; set; }
        public decimal Balance { get; set; }
    }
}
