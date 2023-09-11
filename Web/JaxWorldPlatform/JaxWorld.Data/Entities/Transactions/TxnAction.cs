namespace JaxWorld.Data.Entities.Transactions
{
    using Profiles;
    using Wallets;

    public class TxnAction : Entity
    {
        public string Operation { get; set; }
        public int ProfileId { get; set; }
        public virtual Profile Profile { get; set; }
        public int TargetId { get; set; }
        public virtual Wallet Target { get; set; }
    }
}
