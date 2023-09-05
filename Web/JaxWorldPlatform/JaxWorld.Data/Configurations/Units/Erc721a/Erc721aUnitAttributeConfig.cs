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
