namespace JaxWorld.Data.Configurations.Transaction
{
    using Entities.Transactions;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
