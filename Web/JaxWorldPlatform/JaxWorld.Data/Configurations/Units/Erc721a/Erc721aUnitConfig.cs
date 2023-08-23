namespace JaxWorld.Data.Configurations.Units.Erc721a
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Entities.Units;

    public class Erc721aUnitConfig : IEntityTypeConfiguration<Erc721aUnit>
    {
        public void Configure(EntityTypeBuilder<Erc721aUnit> builder)
        {
            builder.HasOne(s => s.Profile)
            .WithMany(u => u.Erc721aUnits)
            .HasForeignKey(s => s.ProfileId)
            .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(s => s.Holder)
            .WithMany(u => u.Erc721aUnits)
            .HasForeignKey(e => e.HolderId)
            .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
