namespace JaxWorld.Data.Blockchain.Configurations.UserWallet
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Wallets;
    using Contracts;

    public class WalletContractConfig : IEntityTypeConfiguration<Contract>
    {
        public void Configure(EntityTypeBuilder<Contract> builder)
        {
            builder.HasOne(s => s.Creator)
            .WithMany(u => u.ContractsCreated)
            .HasForeignKey(s => s.CreatorId)
            .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(s => s.Owner)
            .WithMany(u => u.ContractsOwned)
            .HasForeignKey(s => s.OwnerId)
            .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(g => g.ApprovedByWallets)
             .WithMany(u => u.ContractsApproved)
                .UsingEntity<Dictionary<string, object>>("WalletsContracts",
                x => x.HasOne<Wallet>().WithMany().HasForeignKey("WalletId")
                      .OnDelete(DeleteBehavior.Restrict),
                x => x.HasOne<Contract>().WithMany().HasForeignKey("ContractId")
                      .OnDelete(DeleteBehavior.Restrict));
        }
    }
}
