namespace JaxWorld.Data.Configurations.Provider
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Entities.Blockchain.Wallets;

    internal class ProviderConfig : IEntityTypeConfiguration<Provider>
    {
        public void Configure(EntityTypeBuilder<Provider> builder)
        {
            builder.HasData(
                    new Provider
                    {
                        Id = 1,
                        Name = "Metamask",
                        NormalizedTag = "Metamask".ToUpper()
                    });
            builder.HasData(
                    new Provider
                    {
                        Id = 2,
                        Name = "Coinbase",
                        NormalizedTag = "Coinbase".ToUpper()
                    });

            builder.HasData(
                    new Provider
                    {
                        Id = 3,
                        Name = "WalletConnect",
                        NormalizedTag = "WalletConnect".ToUpper()
                    });
            builder.HasData(
                    new Provider
                    {
                        Id = 99,
                        Name = "Unknown",
                        NormalizedTag = "Unknown".ToUpper()
                    });
        }
    }
}
