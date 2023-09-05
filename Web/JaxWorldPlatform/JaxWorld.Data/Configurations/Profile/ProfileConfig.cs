namespace JaxWorld.Data.Configurations.Profile
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Entities.Profiles;

    internal class ProfileConfig : IEntityTypeConfiguration<Profile>
    {
        public void Configure(EntityTypeBuilder<Profile> builder)
        {
            builder.HasOne(s => s.Contract)
                .WithOne(u => u.Profile)
                .HasForeignKey<Profile>(e => e.ContractId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(s => s.Standard)
                .WithMany(u => u.Profiles)
                .HasForeignKey(s => s.StandardId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(s => s.Creator)
                .WithMany()
                .HasForeignKey(s => s.CreatorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(s => s.LastModifier)
                .WithMany()
                .HasForeignKey(s => s.LastModifierId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}