namespace JaxWorld.Data.Entities.Blockchain.Configurations.UserWallet
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class WalletUnitConfig : IEntityTypeConfiguration<UnitWalletBalance>
    {
        public void Configure(EntityTypeBuilder<UnitWalletBalance> builder)
        {
            builder.HasOne(s => s.Wallet)
            .WithMany(u => u.Units)
            .HasForeignKey(s => s.WalletId)
            .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
