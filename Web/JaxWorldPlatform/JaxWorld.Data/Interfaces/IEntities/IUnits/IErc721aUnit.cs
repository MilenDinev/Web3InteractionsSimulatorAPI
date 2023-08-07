namespace JaxWorld.Data.Interfaces.IEntities.IUnits
{
    using Entities.Properties;

    public interface IErc721aUnit
    {
        string DNA { get; set; }
        ICollection<Attribute> Attributes { get; set; }
        ICollection<Utility> Utilities { get; set; }
    }
}
