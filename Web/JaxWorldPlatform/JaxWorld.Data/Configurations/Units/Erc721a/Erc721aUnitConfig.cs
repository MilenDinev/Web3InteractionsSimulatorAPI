namespace JaxWorld.Data.Configurations.Units.Erc721a
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Entities.Units;

    internal class Erc721aUnitConfig : IEntityTypeConfiguration<Erc721aUnit>
    {
        public void Configure(EntityTypeBuilder<Erc721aUnit> builder)
        {
            builder.HasOne(erc => erc.Profile)
                .WithMany(p => p.Erc721aUnits)
                .HasForeignKey(erc => erc.ProfileId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(erc => erc.Holder)
                .WithMany(w => w.Erc721aUnits)
                .HasForeignKey(erc => erc.HolderId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(erc => erc.Creator)
                .WithMany()
                .HasForeignKey(erc => erc.CreatorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(erc => erc.LastModifier)
                .WithMany()
                .HasForeignKey(erc => erc.LastModifierId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
