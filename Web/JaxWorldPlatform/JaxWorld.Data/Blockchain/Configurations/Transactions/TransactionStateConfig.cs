namespace JaxWorld.Data.Blockchain.Configurations.Transactions
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Blockchain.Transactions;

    internal class TransactionStateConfig : IEntityTypeConfiguration<TransactionState>
    {
        public void Configure(EntityTypeBuilder<TransactionState> builder)
        {
            builder.HasData(
                    new TransactionState
                    {
                        Id = 1,
                        Value = "Pending"
                    });
            builder.HasData(
                    new TransactionState
                    {
                        Id = 2,
                        Value = "Approved"
                    });

            builder.HasData(
                    new TransactionState
                    {
                        Id = 3,
                        Value = "Rejected"
                    });
        }
    }
}
