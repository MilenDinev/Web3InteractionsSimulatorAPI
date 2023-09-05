namespace JaxWorld.Data.Configurations.Transaction
{
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Microsoft.EntityFrameworkCore;
    using Entities.Transactions;

    internal class TxnLogConfig : IEntityTypeConfiguration<TxnLog>
    {
        public void Configure(EntityTypeBuilder<TxnLog> builder)
        {
            builder.HasOne(tl => tl.Creator)
                .WithMany()
                .HasForeignKey(tl => tl.CreatorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(tl => tl.LastModifier)
                .WithMany()
                .HasForeignKey(tl => tl.LastModifierId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
