namespace JaxWorld.Data.Configurations.User
{
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Microsoft.EntityFrameworkCore;
    using Entities;

    internal class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
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
