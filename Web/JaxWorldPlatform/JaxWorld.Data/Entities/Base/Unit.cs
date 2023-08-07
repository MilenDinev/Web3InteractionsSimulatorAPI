namespace JaxWorld.Data.Entities.Base
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.IEntities.IBase;

    public abstract class Unit : Entity, IUnit
    {
        [Column("Name", Order = 2)]
        public string Name { get; set; }
    }
}