namespace JaxWorld.Data.Entities.Properties
{
    using Microsoft.EntityFrameworkCore;
    using Base;
    using Entities.Units;
    using Interfaces.IEntities.IProperties;

    public class Utility : Property, IUtility
    {
        public Utility()
        {
            Erc721AUnits = new HashSet<Erc721aUnit>();
        }
        public string DisplayType { get; set; }
        [Precision(18, 2)]
        public decimal Value { get; set; }
        public virtual ICollection<Erc721aUnit> Erc721AUnits { get; set; }
    }
}
