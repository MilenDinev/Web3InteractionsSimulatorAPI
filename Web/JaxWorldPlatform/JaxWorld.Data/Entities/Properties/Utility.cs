namespace JaxWorld.Data.Entities.Properties
{
    using Base;
    using Constants;
    using Entities.Units;
    using Microsoft.EntityFrameworkCore;

    public class Utility : Property
    {
        public Utility()
        {
            Erc721AUnits = new HashSet<Erc721aUnit>();
        }
        public string DisplayType { get; set; }
        [Precision(AttributesParams.DecimalPrecision, AttributesParams.DecimalScale)]
        public decimal Value { get; set; }
        public virtual ICollection<Erc721aUnit> Erc721AUnits { get; set; }
    }
}
