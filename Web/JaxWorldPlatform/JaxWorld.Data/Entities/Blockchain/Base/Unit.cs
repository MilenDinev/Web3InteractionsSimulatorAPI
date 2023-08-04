namespace JaxWorld.Data.Entities.Blockchain.Base
{
    using Data.Interfaces.IEntities.IBlockchain.IBase;
    using System.ComponentModel.DataAnnotations.Schema;

    public abstract class Unit : Entity, IUnit
    {
        [Column("Name", Order = 2)]
        public string Name { get; set; }
    }
}