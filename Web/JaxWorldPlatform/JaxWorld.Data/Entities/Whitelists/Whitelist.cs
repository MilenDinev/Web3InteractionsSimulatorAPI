namespace JaxWorld.Data.Entities.Whitelists
{
    using Base;
    using Wallets;

    public class Whitelist : Entity
    {
        public Whitelist()
        {
            this.WhitelistedWallets = new HashSet<Wallet>();       
        }

        public int Id { get; set; }
        public int ProfileId { get; set; }
        public virtual Profile Profile { get; set; }
        public int StatusId { get; set; }
        public virtual WhitelistStatus Status { get; set; }
        public virtual ICollection<Wallet> WhitelistedWallets { get; set; }
    }
}
