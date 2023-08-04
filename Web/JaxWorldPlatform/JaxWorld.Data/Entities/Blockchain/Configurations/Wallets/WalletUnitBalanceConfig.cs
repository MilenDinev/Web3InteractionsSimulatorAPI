namespace JaxWorld.Data.Entities.Blockchain.Configurations.Wallets
{
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Microsoft.EntityFrameworkCore;
    using Blockchain.Units;
    using Blockchain.Wallets;

    public class WalletUnitBalanceConfig : IEntityTypeConfiguration<Erc721aUnit>
    {
        public void Configure(EntityTypeBuilder<Erc721aUnit> builder)
        {
            builder.HasMany(c => c.Holders)
            .WithMany(u => u.Erc721aUnits)
            .UsingEntity<Dictionary<string, object>>("WalletsUnits",
            x => x.HasOne<Wallet>().WithMany().HasForeignKey("WalletId")
                  .OnDelete(DeleteBehavior.Restrict),
            x => x.HasOne<Erc721aUnit>().WithMany().HasForeignKey("UnitId")
                  .OnDelete(DeleteBehavior.Restrict));
        }
    }
}