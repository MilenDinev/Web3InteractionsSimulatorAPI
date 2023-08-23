namespace JaxWorld.Data.Configurations.Transaction
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Entities.Transactions;

    public class TransactionConfig : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasOne(s => s.Network)
            .WithMany(u => u.Transactions)
            .HasForeignKey(s => s.NetworkId)
            .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
