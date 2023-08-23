namespace JaxWorld.Data.Configurations.User
{
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Microsoft.EntityFrameworkCore;
    using Entities.Transactions;


    internal class UserConfig : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {

            // Composite Key UserCreatorID plus WalletAddressCreatorId plus Transaction
        }
    }
}
