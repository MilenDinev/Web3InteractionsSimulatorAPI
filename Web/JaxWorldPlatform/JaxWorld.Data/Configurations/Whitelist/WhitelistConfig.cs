namespace JaxWorld.Data.Configurations.Whitelist
{
    using Entities.Whitelists;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class WhitelistConfig : IEntityTypeConfiguration<Whitelist>
    {
        public void Configure(EntityTypeBuilder<Whitelist> builder)
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
