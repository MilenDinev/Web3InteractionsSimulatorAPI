namespace JaxWorld.Data.Configurations.Wallets
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Data.Entities.Blockchain.Units;

    public class WalletErc721aUnitConfig : IEntityTypeConfiguration<Erc721aUnit>
    {
        public void Configure(EntityTypeBuilder<Erc721aUnit> builder)
        {
            builder.HasOne(s => s.Holder)
            .WithMany(u => u.Erc721aUnits)
            .HasForeignKey(e => e.HolderId)
            .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
