namespace JaxWorld.Data.Entities.Properties
{
    using Base;
    using Entities.Units;

    public class Attribute : Property
    {
        public Attribute()
        {
            Erc721AUnits = new HashSet<Erc721aUnit>();
        }
        public string Value { get; set; }
        public virtual ICollection<Erc721aUnit> Erc721AUnits { get; set; }
    }
}
