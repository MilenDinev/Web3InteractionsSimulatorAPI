namespace JaxWorld.Data.Entities.Blockchain.Configurations.Provider
{
    using Blockchain.Wallets;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class ProviderConfig : IEntityTypeConfiguration<Provider>
    {
        public void Configure(EntityTypeBuilder<Provider> builder)
        {
            builder.HasData(
                    new Provider
                    {
                        Id = 1,
                        Name = "Metamask"
                    });
            builder.HasData(
                    new Provider
                    {
                        Id = 2,
                        Name = "Coinbase"
                    });

            builder.HasData(
                    new Provider
                    {
                        Id = 3,
                        Name = "WalletConnect"
                    });
        }
    }
}
