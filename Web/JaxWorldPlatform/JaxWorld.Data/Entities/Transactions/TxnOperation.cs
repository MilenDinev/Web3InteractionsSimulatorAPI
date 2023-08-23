namespace JaxWorld.Data.Entities.Transactions
{
    using Wallets;
    using Profiles;

    public class TxnOperation
    {
        public int Id { get; set; }
        public string Operation { get; set; }
        public int ProfileId { get; set; }
        public virtual Profile Profile { get; set; }
        public int TargetId { get; set; }
        public virtual Wallet Target { get; set; }
    }
}
