namespace JaxWorld.Data.Configurations.Transaction
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Entities.Transactions;

    internal class TransactionConfig : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasOne(t => t.Network)
                .WithMany(n => n.Transactions)
                .HasForeignKey(t => t.NetworkId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(t => t.Creator)
                .WithMany()
                .HasForeignKey(t => t.CreatorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(t => t.LastModifier)
                .WithMany()
                .HasForeignKey(t => t.LastModifierId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(t => t.State)
                .WithMany(ts => ts.Transactions)
                .HasForeignKey(t => t.StateId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
