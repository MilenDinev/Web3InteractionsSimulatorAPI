namespace JaxWorld.Data.Entities.Base
{
    using Constants;
    using System.ComponentModel.DataAnnotations.Schema;

    public abstract class Unit : Entity
    {
        [Column(AttributesParams.Name, Order = 2)]
        public string Name { get; set; }
    }
}