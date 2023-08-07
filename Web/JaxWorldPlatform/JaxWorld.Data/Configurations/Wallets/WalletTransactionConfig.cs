namespace JaxWorld.Data.Configurations.Wallets
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Entities.Transactions;

    public class WalletTransactionConfig : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasOne(s => s.Creator)
            .WithMany(u => u.Transactions)
            .HasForeignKey(s => s.CreatorId)
            .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
