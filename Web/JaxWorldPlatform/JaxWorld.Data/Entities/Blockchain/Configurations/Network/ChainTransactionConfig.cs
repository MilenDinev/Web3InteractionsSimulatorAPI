namespace JaxWorld.Data.Entities.Blockchain.Configurations.Network
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Blockchain.Transactions;

    public class ChainTransactionConfig : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasOne(s => s.Chain)
            .WithMany(u => u.Transactions)
            .HasForeignKey(s => s.ChainId)
            .OnDelete(DeleteBehavior.Restrict);
        }
    }
}