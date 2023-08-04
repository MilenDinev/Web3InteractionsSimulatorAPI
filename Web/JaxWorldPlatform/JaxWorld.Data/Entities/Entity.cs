namespace JaxWorld.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.IEntities;

    public abstract class Entity : IEntity
    {
        [Column("Id", Order = 0)]
        public int Id { get; set; }
        public string? NormalizedName { get; set; }
        public int CreatorId { get; set; }
        public DateTime CreatedOn { get; set; }
        public int LastModifierId { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public bool Deleted { get; set; }
    }
}
