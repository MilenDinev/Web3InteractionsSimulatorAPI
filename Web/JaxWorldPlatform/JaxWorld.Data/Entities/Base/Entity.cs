namespace JaxWorld.Data.Entities.Base
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using Constants;
    using Interfaces.IEntities;

    public abstract class Entity : IEntity
    {
        [Column(AttributesParams.Id, Order = 0)]
        public int Id { get; set; }
        public string NormalizedTag { get; set; }
        public int CreatorId { get; set; }
        public virtual User Creator { get; set; }
        public DateTime CreationDate { get; set; }
        public int LastModifierId { get; set; }
        public virtual User LastModifier { get; set; }
        public DateTime LastModificationDate { get; set; }
        public bool Deleted { get; set; }
    }
}
