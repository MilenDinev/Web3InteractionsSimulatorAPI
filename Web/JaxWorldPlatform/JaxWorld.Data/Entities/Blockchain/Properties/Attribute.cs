namespace JaxWorld.Data.Entities.Blockchain.Properties
{
    using Base;
    using Blockchain.Units;
    using Interfaces.IEntities.IBlockchain.IProperties;

    public class Attribute : Property, IAttribute
    {
        public Attribute()
        {
            this.Erc721AUnits = new HashSet<Erc721aUnit>();
        }
        public string Value { get; set; }
        public virtual ICollection<Erc721aUnit> Erc721AUnits { get; set; }
    }
}
