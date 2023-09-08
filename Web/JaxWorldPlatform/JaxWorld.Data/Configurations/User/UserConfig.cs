namespace JaxWorld.Data.Configurations.User
{
    using Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
