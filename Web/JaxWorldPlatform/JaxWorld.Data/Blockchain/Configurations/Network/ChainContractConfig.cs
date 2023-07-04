namespace JaxWorld.Data.Blockchain.Configurations.Network
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Contracts;

    public class ChainContractConfig : IEntityTypeConfiguration<Contract>
    {
        public void Configure(EntityTypeBuilder<Contract> builder)
        {
            builder.HasOne(s => s.Chain)
            .WithMany(u => u.Contracts)
            .HasForeignKey(s => s.ChainId)
            .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
