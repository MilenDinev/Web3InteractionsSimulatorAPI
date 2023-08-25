namespace JaxWorld.Data.Configurations.Contract
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Entities.Contracts;

    internal class ContractConfig : IEntityTypeConfiguration<Contract>
    {
        public void Configure(EntityTypeBuilder<Contract> builder)
        {
            builder.HasOne(s => s.CreatorWallet)
                .WithMany(u => u.CreatedContracts)
                .HasForeignKey(s => s.CreatorWalletId)
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
