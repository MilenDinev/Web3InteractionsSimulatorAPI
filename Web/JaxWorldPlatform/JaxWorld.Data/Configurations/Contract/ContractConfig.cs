namespace JaxWorld.Data.Configurations.Contract
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Entities.Contracts;

    internal class ContractConfig : IEntityTypeConfiguration<Contract>
    {
        public void Configure(EntityTypeBuilder<Contract> builder)
        {
            builder.HasOne(c => c.CreatorWallet)
                .WithMany(w => w.CreatedContracts)
                .HasForeignKey(c => c.CreatorWalletId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Network)
                .WithMany(n => n.Contracts)
                .HasForeignKey(c => c.NetworkId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(s => s.Creator)
                .WithMany()
                .HasForeignKey(s => s.CreatorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(s => s.LastModifier)
                .WithMany()
                .HasForeignKey(s => s.LastModifierId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
