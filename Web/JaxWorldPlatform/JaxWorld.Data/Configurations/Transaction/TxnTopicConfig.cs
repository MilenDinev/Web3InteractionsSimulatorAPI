namespace JaxWorld.Data.Configurations.Transaction
{
    using Entities.Transactions;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class TxnTopicConfig : IEntityTypeConfiguration<TxnTopic>
    {
        public void Configure(EntityTypeBuilder<TxnTopic> builder)
        {
            builder.HasOne(tt => tt.Creator)
                .WithMany()
                .HasForeignKey(tt => tt.CreatorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(tt => tt.LastModifier)
                .WithMany()
                .HasForeignKey(tt => tt.LastModifierId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
