namespace JaxWorld.Data.Entities.Blockchain.Wallets
{
    public class Provider: Entity 
    {
        public Provider() 
        { 
            this.Wallets = new HashSet<Wallet>();        
        }
        public string Name { get; set; }
        public ICollection<Wallet> Wallets { get; set;}
    }
}
