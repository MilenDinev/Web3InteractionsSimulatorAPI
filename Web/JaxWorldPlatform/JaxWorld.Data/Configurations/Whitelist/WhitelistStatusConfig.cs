namespace JaxWorld.Data.Configurations.WhitelistStatus
{
    using Entities.Whitelists;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class WhitelistStatusConfig : IEntityTypeConfiguration<WhitelistStatus>
    {
        public void Configure(EntityTypeBuilder<WhitelistStatus> builder)
        {

            builder.HasOne(w => w.Creator)
                .WithMany()
                .HasForeignKey(w => w.CreatorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(w => w.LastModifier)
                .WithMany()
                .HasForeignKey(w => w.LastModifierId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
