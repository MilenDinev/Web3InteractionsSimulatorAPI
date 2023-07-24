namespace JaxWorld.Data.Entities.Blockchain.Configurations.UserWallet
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
