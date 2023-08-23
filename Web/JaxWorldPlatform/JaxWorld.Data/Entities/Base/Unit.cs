namespace JaxWorld.Data.Entities.Base
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Constants;

    public abstract class Unit : Entity
    {
        [Column(AttributesParams.Name, Order = 2)]
        public string Name { get; set; }
    }
}