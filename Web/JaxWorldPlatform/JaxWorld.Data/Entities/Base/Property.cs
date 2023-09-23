namespace JaxWorld.Data.Entities.Base
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Constants;

    public abstract class Property : Entity
    {
        [Column(AttributesParams.TraitType, Order = 2)]
        public string TraitType { get; set; } = string.Empty;
    }
}
