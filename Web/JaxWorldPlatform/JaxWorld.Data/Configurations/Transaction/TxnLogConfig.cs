namespace JaxWorld.Data.Configurations.Transaction
{
    using Entities.Transactions;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
