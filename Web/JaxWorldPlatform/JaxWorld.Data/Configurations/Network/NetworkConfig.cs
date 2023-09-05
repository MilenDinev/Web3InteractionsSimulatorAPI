namespace JaxWorld.Data.Configurations.Network
{
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Microsoft.EntityFrameworkCore;
    using Entities;

    internal class NetworkConfig : IEntityTypeConfiguration<Network>
    {
        public void Configure(EntityTypeBuilder<Network>builder)
        {
            builder.HasOne(n => n.Creator)
                .WithMany()
                .HasForeignKey(n => n.CreatorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(n => n.LastModifier)
                .WithMany()
                .HasForeignKey(n => n.LastModifierId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
