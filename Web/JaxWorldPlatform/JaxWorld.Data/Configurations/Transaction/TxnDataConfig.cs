namespace JaxWorld.Data.Configurations.Transaction
{
    using Entities.Transactions;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class TxnDataConfig : IEntityTypeConfiguration<TxnData>
    {
        public void Configure(EntityTypeBuilder<TxnData> builder)
        {
            builder.HasOne(td => td.Creator)
                .WithMany()
                .HasForeignKey(td => td.CreatorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(td => td.LastModifier)
                .WithMany()
                .HasForeignKey(td => td.LastModifierId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
