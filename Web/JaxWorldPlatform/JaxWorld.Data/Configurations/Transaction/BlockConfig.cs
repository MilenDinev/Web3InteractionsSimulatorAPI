namespace JaxWorld.Data.Configurations.Transaction
{
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Microsoft.EntityFrameworkCore;
    using Entities.Transactions;

    internal class BlockConfig : IEntityTypeConfiguration<Block>
    {
        public void Configure(EntityTypeBuilder<Block> builder)
        {
            builder.HasOne(b => b.Creator)
                .WithMany()
                .HasForeignKey(b => b.CreatorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(b => b.LastModifier)
                .WithMany()
                .HasForeignKey(b => b.LastModifierId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
