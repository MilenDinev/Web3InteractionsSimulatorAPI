namespace JaxWorld.Data.Entities.Blockchain.Configurations.Contract
{
    using Blockchain.Transactions;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
