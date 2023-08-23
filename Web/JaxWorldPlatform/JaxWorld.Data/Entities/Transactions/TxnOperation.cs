namespace JaxWorld.Data.Entities.Transactions
{
    using Wallets;
    using Profiles;

    public class TxnOperation
    {
        public int Id { get; set; }
        public string Operation { get; set; }
        public int ProfileId { get; set; }
        public Profile Profile { get; set; }
        public int TargetId { get; set; }
        public Wallet Target { get; set; }
    }
}
