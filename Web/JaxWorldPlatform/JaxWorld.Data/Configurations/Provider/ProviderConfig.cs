namespace JaxWorld.Data.Configurations.Provider
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Entities.Wallets;

    internal class ProviderConfig : IEntityTypeConfiguration<Provider>
    {
        public void Configure(EntityTypeBuilder<Provider> builder)
        {

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
