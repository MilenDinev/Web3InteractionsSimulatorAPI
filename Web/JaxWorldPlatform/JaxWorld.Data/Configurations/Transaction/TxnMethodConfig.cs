namespace JaxWorld.Data.Configurations.Transaction
{
    using Entities.Transactions;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
