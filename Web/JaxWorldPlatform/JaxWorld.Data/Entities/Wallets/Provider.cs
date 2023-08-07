namespace JaxWorld.Data.Entities.Wallets
{
    public class Provider : Entity
    {
        public Provider()
        {
            Wallets = new HashSet<Wallet>();
        }
        public string Name { get; set; }
        public virtual ICollection<Wallet> Wallets { get; set; }
    }
}
