namespace JaxWorld.Data.Entities.Blockchain.Configurations.UserWallet
{
    using JaxWorld.Data.Entities.Blockchain;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Tokens;

    public class WalletTokenConfig : IEntityTypeConfiguration<TokenWalletBalance>
    {
        public void Configure(EntityTypeBuilder<TokenWalletBalance> builder)
        {
            builder.HasOne(s => s.Wallet)
            .WithMany(u => u.Tokens)
            .HasForeignKey(s => s.WalletId)
            .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
