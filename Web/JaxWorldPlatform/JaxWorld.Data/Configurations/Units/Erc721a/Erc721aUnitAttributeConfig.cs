namespace JaxWorld.Data.Configurations.Units.Erc721a
{
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Microsoft.EntityFrameworkCore;
    using Entities.Units;
    using Entities.Properties;

    internal class Erc721aUnitAttributeConfig : IEntityTypeConfiguration<Attribute>
    {
        public void Configure(EntityTypeBuilder<Attribute> builder)
        {
            builder.HasMany(g => g.Erc721AUnits)
             .WithMany(u => u.Attributes)
                .UsingEntity<Dictionary<string, object>>("Erc721aUnitsAttributes",
                x => x.HasOne<Erc721aUnit>().WithMany().HasForeignKey("Erc721aUnitId")
                      .OnDelete(DeleteBehavior.Restrict),
                x => x.HasOne<Attribute>().WithMany().HasForeignKey("AttributeId")
                      .OnDelete(DeleteBehavior.Restrict));
        }
    }
}
