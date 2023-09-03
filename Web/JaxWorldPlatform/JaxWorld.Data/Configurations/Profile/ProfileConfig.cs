namespace JaxWorld.Data.Configurations.Profile
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Entities.Profiles;

    internal class ProfileConfig : IEntityTypeConfiguration<Profile>
    {
        public void Configure(EntityTypeBuilder<Profile> builder)
        {
            builder.HasOne(p => p.Contract)
                .WithOne(c => c.Profile)
                .HasForeignKey<Profile>(p => p.ContractId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Standard)
                .WithMany(s => s.Profiles)
                .HasForeignKey(p => p.StandardId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Creator)
                .WithMany()
                .HasForeignKey(p => p.CreatorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.LastModifier)
                .WithMany()
                .HasForeignKey(p => p.LastModifierId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}