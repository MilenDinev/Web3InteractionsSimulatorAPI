namespace JaxWorld.Data.Entities.Blockchain.Configurations.Network
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Contracts;

    public class ChainContractConfig : IEntityTypeConfiguration<Contract>
    {
        public void Configure(EntityTypeBuilder<Contract> builder)
        {
            builder.HasMany(c => c.Networks)
            .WithMany(u => u.Contracts)
            .UsingEntity<Dictionary<string, object>>("ChainsContracts",
            x => x.HasOne<Blockchain.Network>().WithMany().HasForeignKey("NetworkId")
                  .OnDelete(DeleteBehavior.Restrict),
            x => x.HasOne<Contract>().WithMany().HasForeignKey("ContractId")
                  .OnDelete(DeleteBehavior.Restrict));
        }
    }
}