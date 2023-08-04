namespace JaxWorld.Data.Entities.Blockchain.Configurations.Network
{
    using System.Collections.Generic;
    using Blockchain.Wallets;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ChainWalletConfig : IEntityTypeConfiguration<Wallet>
    {
        public void Configure(EntityTypeBuilder<Wallet> builder)
        {
            builder.HasMany(g => g.Chains)
             .WithMany(u => u.Users)
                .UsingEntity<Dictionary<string, object>>("ChainsWallets",
                x => x.HasOne<Blockchain.Network>().WithMany().HasForeignKey("NetworkId")
                      .OnDelete(DeleteBehavior.Restrict),
                x => x.HasOne<Wallet>().WithMany().HasForeignKey("WalletId")
                      .OnDelete(DeleteBehavior.Restrict));
        }
    }
}
