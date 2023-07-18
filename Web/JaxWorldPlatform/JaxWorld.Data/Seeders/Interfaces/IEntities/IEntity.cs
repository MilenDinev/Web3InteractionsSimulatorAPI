namespace JaxWorld.Data.Interfaces.IEntities
{
    public interface IEntity
    {
        int Id { get; set; }
        string NormalizedName { get; set; }
        int CreatorId { get; set; }
        DateTime CreatedOn { get; set; }
        int LastModifierId { get; set; }
        DateTime LastModifiedOn { get; set; }
        bool Deleted { get; set; }
    }
}
