namespace JaxWorld.Data.Configurations.Network
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Entities.Blockchain;
    using Entities.Blockchain.Contracts;

    public class NetworkContractConfig : IEntityTypeConfiguration<Contract>
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
