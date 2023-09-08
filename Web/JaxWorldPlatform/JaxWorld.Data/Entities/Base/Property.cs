namespace JaxWorld.Data.Entities.Base
{
    using Constants;
    using Interfaces.IEntities.IBase;
    using System.ComponentModel.DataAnnotations.Schema;

    public abstract class Property : Entity, IProperty
    {
        [Column(AttributesParams.TraitType, Order = 2)]
        public string TraitType { get; set; }
    }
}
