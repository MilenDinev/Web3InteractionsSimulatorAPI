namespace JaxWorld.Data.Configurations.Units.Erc721a
{
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Microsoft.EntityFrameworkCore;
    using Entities.Transactions;

    public class Erc721aUnitTransactionConfig : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasOne(s => s.Erc721aUnit)
            .WithMany(u => u.Transactions)
            .HasForeignKey(s => s.Erc721aUnitId)
            .OnDelete(DeleteBehavior.Restrict);
        }
    }
}