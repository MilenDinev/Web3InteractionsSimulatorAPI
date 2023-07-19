namespace JaxWorld.Data.Entities.Blockchain.Configurations.UserWallet
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Blockchain;
    using Contracts;

    public class WalletContractConfig : IEntityTypeConfiguration<Contract>
    {
        public void Configure(EntityTypeBuilder<Contract> builder)
        {
   
            builder.HasMany(g => g.Networks)
             .WithMany(u => u.Contracts)
                .UsingEntity<Dictionary<string, object>>("NetworksContracts",
                x => x.HasOne<Network>().WithMany().HasForeignKey("NetworkId")
                      .OnDelete(DeleteBehavior.Restrict),
                x => x.HasOne<Contract>().WithMany().HasForeignKey("ContractId")
                      .OnDelete(DeleteBehavior.Restrict));
        }
    }
}
