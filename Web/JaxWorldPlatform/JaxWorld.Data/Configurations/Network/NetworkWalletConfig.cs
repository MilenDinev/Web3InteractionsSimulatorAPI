namespace JaxWorld.Data.Configurations.Network
{
    using Entities;
    using Entities.Wallets;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using System.Collections.Generic;

    internal class NetworkWalletConfig : IEntityTypeConfiguration<Wallet>
    {
        public void Configure(EntityTypeBuilder<Wallet> builder)
        {
            builder.HasMany(w => w.Networks)
             .WithMany(n => n.Wallets)
                .UsingEntity<Dictionary<string, object>>("NetworksWallets",
                nw => nw.HasOne<Network>().WithMany().HasForeignKey("NetworkId")
                      .OnDelete(DeleteBehavior.Restrict),
                nw => nw.HasOne<Wallet>().WithMany().HasForeignKey("WalletId")
                      .OnDelete(DeleteBehavior.Restrict));
        }
    }
}
