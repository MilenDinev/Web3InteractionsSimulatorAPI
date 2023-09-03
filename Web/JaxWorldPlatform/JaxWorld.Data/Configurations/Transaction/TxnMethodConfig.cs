namespace JaxWorld.Data.Configurations.Transaction
{
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Microsoft.EntityFrameworkCore;
    using Entities.Transactions;

    internal class TxnMethodConfig : IEntityTypeConfiguration<TxnMethod>
    {
        public void Configure(EntityTypeBuilder<TxnMethod> builder)
        {
            builder.HasOne(tm => tm.Creator)
                .WithMany()
                .HasForeignKey(tm => tm.CreatorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(tm => tm.LastModifier)
                .WithMany()
                .HasForeignKey(tm => tm.LastModifierId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
