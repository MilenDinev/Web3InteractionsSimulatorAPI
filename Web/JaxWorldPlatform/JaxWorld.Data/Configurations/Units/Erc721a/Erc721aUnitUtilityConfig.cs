namespace JaxWorld.Data.Configurations.Units.Erc721a
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Entities.Units;
    using Entities.Properties;

    internal class Erc721aUnitUtilityConfig : IEntityTypeConfiguration<Utility>
    {
        public void Configure(EntityTypeBuilder<Utility> builder)
        {
            builder.HasMany(g => g.Erc721AUnits)
             .WithMany(u => u.Utilities)
                .UsingEntity<Dictionary<string, object>>("Erc721aUnitsUtilities",
                x => x.HasOne<Erc721aUnit>().WithMany().HasForeignKey("Erc721aUnitId")
                      .OnDelete(DeleteBehavior.Restrict),
                x => x.HasOne<Utility>().WithMany().HasForeignKey("UtilityId")
                      .OnDelete(DeleteBehavior.Restrict));
        }
    }
}
