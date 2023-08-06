namespace JaxWorld.Data.Configurations.Standard
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Entities.Blockchain.Profiles;

    public class StandardProfileConfig : IEntityTypeConfiguration<Profile>
    {
        public void Configure(EntityTypeBuilder<Profile> builder)
        {
            builder.HasOne(s => s.Standard)
            .WithMany(u => u.Profiles)
            .HasForeignKey(s => s.StandardId)
            .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
