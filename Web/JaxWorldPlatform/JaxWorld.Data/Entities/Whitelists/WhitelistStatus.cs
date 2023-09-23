namespace JaxWorld.Data.Entities.Whitelists
{
    using Base;

    public class WhitelistStatus : Entity
    {
        public WhitelistStatus()
        {
            this.Whitelists = new HashSet<Whitelist>();    
        }

        public int Id { get; set; }
        public string Status { get; set; }
        public virtual ICollection<Whitelist> Whitelists { get; set; }
    }
}
