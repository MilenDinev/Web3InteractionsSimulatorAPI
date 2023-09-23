namespace JaxWorld.Data.Entities
{
    using Base;
    using JaxWorld.Data.Entities.Whitelists;
    using Units;

    public class Profile : Entity
    {
        public Profile()
        {
            Erc721aUnits = new HashSet<Erc721aUnit>();
        }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string Description { get; set; }
        public int TotalSupply { get; set; }
        public int TotalMinted { get; set; }
        public virtual Whitelist Whitelist { get; set; }
        public int StandardId { get; set; }
        public virtual Standard Standard { get; set; }
        public int ContractId { get; set; }
        public virtual Contract Contract { get; set; }
        public virtual ICollection<Erc721aUnit> Erc721aUnits { get; set; }
    }
}
