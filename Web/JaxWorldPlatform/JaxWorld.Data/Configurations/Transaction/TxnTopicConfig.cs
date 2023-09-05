namespace JaxWorld.Data.Configurations.Transaction
{
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Microsoft.EntityFrameworkCore;
    using Entities.Transactions;

    internal class TxnTopicConfig : IEntityTypeConfiguration<TxnTopic>
    {
        public void Configure(EntityTypeBuilder<TxnTopic> builder)
        {
            builder.HasOne(s => s.Creator)
                .WithMany()
                .HasForeignKey(s => s.CreatorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(s => s.LastModifier)
                .WithMany()
                .HasForeignKey(s => s.LastModifierId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
