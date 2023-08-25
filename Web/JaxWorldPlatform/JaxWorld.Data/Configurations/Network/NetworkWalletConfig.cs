namespace JaxWorld.Data.Configurations.Network
{
    using System.Collections.Generic;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Entities;
    using Entities.Wallets;

    internal class NetworkWalletConfig : IEntityTypeConfiguration<Wallet>
    {
        public void Configure(EntityTypeBuilder<Wallet> builder)
        {
            builder.HasMany(g => g.Networks)
             .WithMany(u => u.Users)
                .UsingEntity<Dictionary<string, object>>("NetworksWallets",
                x => x.HasOne<Network>().WithMany().HasForeignKey("NetworkId")
                      .OnDelete(DeleteBehavior.Restrict),
                x => x.HasOne<Wallet>().WithMany().HasForeignKey("WalletId")
                      .OnDelete(DeleteBehavior.Restrict));
        }
    }
}
