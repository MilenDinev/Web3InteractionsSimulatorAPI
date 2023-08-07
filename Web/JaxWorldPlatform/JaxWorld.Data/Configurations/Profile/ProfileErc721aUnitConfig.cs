namespace JaxWorld.Data.Configurations.Profile
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Entities.Units;

    public class ProfileErc721aUnitConfig : IEntityTypeConfiguration<Erc721aUnit>
    {
        public void Configure(EntityTypeBuilder<Erc721aUnit> builder)
        {
            builder.HasOne(s => s.Profile)
            .WithMany(u => u.Erc721aUnits)
            .HasForeignKey(s => s.ProfileId)
            .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
