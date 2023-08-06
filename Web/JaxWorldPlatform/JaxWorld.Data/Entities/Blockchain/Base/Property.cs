namespace JaxWorld.Data.Entities.Blockchain.Properties.Base
{
    using Interfaces.IEntities.IBlockchain.IProperties;
    using System.ComponentModel.DataAnnotations.Schema;

    public abstract class Property : Entity, IProperty
    {
        [Column("TraitType", Order = 2)]
        public string TraitType { get; set; }
    }
}
