namespace JaxWorld.Data.Configurations.Contract
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Entities.Transactions;

    public class ContractTransactionConfig : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasOne(s => s.Contract)
            .WithMany(u => u.Transactions)
            .HasForeignKey(s => s.ContractId)
            .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
