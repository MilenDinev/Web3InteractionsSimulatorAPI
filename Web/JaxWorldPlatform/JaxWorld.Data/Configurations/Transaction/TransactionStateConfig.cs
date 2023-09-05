namespace JaxWorld.Data.Configurations.Transaction
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Entities.Transactions;

    internal class TransactionStateConfig : IEntityTypeConfiguration<TransactionState>
    {
        public void Configure(EntityTypeBuilder<TransactionState> builder)
        {
            builder.HasOne(ts => ts.Creator)
                .WithMany()
                .HasForeignKey(ts => ts.CreatorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(ts => ts.LastModifier)
                .WithMany()
                .HasForeignKey(ts => ts.LastModifierId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
