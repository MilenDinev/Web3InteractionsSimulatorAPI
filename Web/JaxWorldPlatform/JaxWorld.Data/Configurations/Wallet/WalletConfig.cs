namespace JaxWorld.Data.Configurations.Wallet
{
    using Entities.Wallets;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class WalletConfig : IEntityTypeConfiguration<Wallet>
    {
        public void Configure(EntityTypeBuilder<Wallet> builder)
        {
            builder.HasOne(w => w.Owner)
                .WithMany(u => u.Wallets)
                .HasForeignKey(w => w.OwnerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(w => w.Provider)
                .WithMany(p => p.Wallets)
                .HasForeignKey(w => w.ProviderId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(w => w.Creator)
                .WithMany()
                .HasForeignKey(w => w.CreatorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(w => w.LastModifier)
                .WithMany()
                .HasForeignKey(w => w.LastModifierId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
