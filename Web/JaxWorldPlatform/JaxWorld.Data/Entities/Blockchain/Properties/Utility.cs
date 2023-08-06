namespace JaxWorld.Data.Entities.Blockchain.Properties
{
    using Base;
    using Data.Entities.Blockchain.Units;
    using Interfaces.IEntities.IBlockchain.IProperties;
    using Microsoft.EntityFrameworkCore;

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
