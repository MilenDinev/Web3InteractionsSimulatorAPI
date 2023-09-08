namespace JaxWorld.Data.Configurations.Properties
{
    using Entities.Properties;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class UtilityConfig : IEntityTypeConfiguration<Utility>
    {
        public void Configure(EntityTypeBuilder<Utility> builder)
        {
            builder.HasOne(u => u.Creator)
                .WithMany()
                .HasForeignKey(u => u.CreatorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(u => u.LastModifier)
                .WithMany()
                .HasForeignKey(u => u.LastModifierId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}