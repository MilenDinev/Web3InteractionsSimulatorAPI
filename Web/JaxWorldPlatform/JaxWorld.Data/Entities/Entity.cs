namespace JaxWorld.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.IEntities;

    public abstract class Entity : IEntity
    {
        [Column("Id", Order = 0)]
        public int Id { get; set; }
        public string NormalizedTag { get; set; }
        public int CreatorId { get; set; }
        public DateTime CreationDate { get; set; }
        public int LastModifierId { get; set; }
        public DateTime LastModificationDate { get; set; }
        public bool Deleted { get; set; }
    }
}
