namespace JaxWorld.Data.Entities.Blockchain.Properties.Base
{
    using Interfaces.IEntities.IBlockchain.IProperties;
    using System.ComponentModel.DataAnnotations.Schema;

    public abstract class Property : Entity, IProperty
    {
        [Column("Type", Order = 2)]
        public string Type { get; set; }
    }
}
