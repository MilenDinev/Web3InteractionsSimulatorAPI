namespace JaxWorld.Data.Configurations.Profile
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Entities.Profiles;

    public class ProfileConfig : IEntityTypeConfiguration<Profile>
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
        }
    }
}