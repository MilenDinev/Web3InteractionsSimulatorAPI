namespace JaxWorld.Data.Interfaces.IEntities
{
    using Data.Entities.Contracts;

    public interface IStandard
    {
        string Name { get; set; }
        ICollection<Contract> Contracts { get; set; }
    }
}