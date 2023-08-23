namespace JaxWorld.Data.Entities.Base
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Constants;
    using Interfaces.IEntities.IBase;

    public abstract class Property : Entity, IProperty
    {
        [Column(AttributesParams.TraitType, Order = 2)]
        public string TraitType { get; set; }
    }
}
