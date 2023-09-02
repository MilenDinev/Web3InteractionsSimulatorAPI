namespace JaxWorld.Data.Configurations.Transaction
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Entities.Transactions;

    internal class TransactionConfig : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasOne(s => s.Network)
                .WithMany(u => u.Transactions)
                .HasForeignKey(s => s.NetworkId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(s => s.Creator)
                .WithMany()
                .HasForeignKey(s => s.CreatorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(s => s.LastModifier)
                .WithMany()
                .HasForeignKey(s => s.LastModifierId)
            builder.HasOne(t => t.State)
                .WithMany(ts => ts.Transactions)
                .HasForeignKey(t => t.StateId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
