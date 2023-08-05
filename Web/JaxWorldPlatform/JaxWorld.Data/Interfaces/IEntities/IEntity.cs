namespace JaxWorld.Data.Interfaces.IEntities
{
    public interface IEntity
    {
        int Id { get; set; }
        string NormalizedTag { get; set; }
        int CreatorId { get; set; }
        DateTime CreationDate { get; set; }
        int LastModifierId { get; set; }
        DateTime LastModificationDate { get; set; }
        bool Deleted { get; set; }
    }
}
