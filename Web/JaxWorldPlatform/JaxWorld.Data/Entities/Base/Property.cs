namespace JaxWorld.Data.Entities.Base
{
    using Constants;
    using System.ComponentModel.DataAnnotations.Schema;

    public abstract class Property : Entity
    {
        [Column(AttributesParams.TraitType, Order = 2)]
        public string TraitType { get; set; } = string.Empty;
    }
}
