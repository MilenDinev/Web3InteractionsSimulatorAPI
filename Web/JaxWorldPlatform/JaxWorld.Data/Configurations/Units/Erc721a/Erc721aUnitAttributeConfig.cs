namespace JaxWorld.Data.Configurations.Units.Erc721a
{
    using Entities.Properties;
    using Entities.Units;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class Erc721aUnitAttributeConfig : IEntityTypeConfiguration<Attribute>
    {
        public void Configure(EntityTypeBuilder<Attribute> builder)
        {
            builder.HasMany(a => a.Erc721AUnits)
             .WithMany(erc => erc.Attributes)
                .UsingEntity<Dictionary<string, object>>("Erc721aUnitsAttributes",
                ea => ea.HasOne<Erc721aUnit>().WithMany().HasForeignKey("Erc721aUnitId")
                      .OnDelete(DeleteBehavior.Restrict),
                ea => ea.HasOne<Attribute>().WithMany().HasForeignKey("AttributeId")
                      .OnDelete(DeleteBehavior.Restrict));
        }
    }
}
