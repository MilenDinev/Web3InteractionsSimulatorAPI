namespace JaxWorld.Data.Configurations.Units.Erc721a
{
    using Entities.Properties;
    using Entities.Units;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class Erc721aUnitUtilityConfig : IEntityTypeConfiguration<Utility>
    {
        public void Configure(EntityTypeBuilder<Utility> builder)
        {
            builder.HasMany(u => u.Erc721AUnits)
             .WithMany(erc => erc.Utilities)
                .UsingEntity<Dictionary<string, object>>("Erc721aUnitsUtilities",
                eu => eu.HasOne<Erc721aUnit>().WithMany().HasForeignKey("Erc721aUnitId")
                      .OnDelete(DeleteBehavior.Restrict),
                eu => eu.HasOne<Utility>().WithMany().HasForeignKey("UtilityId")
                      .OnDelete(DeleteBehavior.Restrict));
        }
    }
}
