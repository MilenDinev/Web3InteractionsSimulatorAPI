namespace JaxWorld.Data.Configurations.Contract
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Entities.Contracts;

    public class ContractConfig : IEntityTypeConfiguration<Contract>
    {
        public void Configure(EntityTypeBuilder<Contract> builder)
        {
            builder.HasOne(s => s.CreatorWallet)
                .WithMany(u => u.CreatedContracts)
                .HasForeignKey(s => s.CreatorWalletId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
