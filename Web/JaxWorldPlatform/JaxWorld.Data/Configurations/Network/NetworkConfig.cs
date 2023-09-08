namespace JaxWorld.Data.Configurations.Network
{
    using Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
