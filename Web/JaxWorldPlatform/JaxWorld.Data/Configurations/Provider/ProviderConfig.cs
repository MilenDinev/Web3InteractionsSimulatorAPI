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
