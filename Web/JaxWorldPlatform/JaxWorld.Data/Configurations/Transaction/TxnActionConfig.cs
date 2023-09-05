namespace JaxWorld.Data.Configurations.Transaction
{
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Microsoft.EntityFrameworkCore;
    using Entities.Transactions;

    internal class TxnActionConfig : IEntityTypeConfiguration<TxnAction>
    {
        public void Configure(EntityTypeBuilder<TxnAction> builder)
        {
            builder.HasOne(ta => ta.Creator)
                .WithMany()
                .HasForeignKey(ta => ta.CreatorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(ta => ta.LastModifier)
                .WithMany()
                .HasForeignKey(ta => ta.LastModifierId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
