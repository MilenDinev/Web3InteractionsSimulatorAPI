namespace JaxWorld.Data.Configurations.Transaction
{
    using Entities.Transactions;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
