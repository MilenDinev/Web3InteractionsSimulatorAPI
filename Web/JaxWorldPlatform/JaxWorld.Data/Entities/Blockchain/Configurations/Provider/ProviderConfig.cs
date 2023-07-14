namespace JaxWorld.Data.Entities.Blockchain.Configurations.Provider
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class ProviderConfig : IEntityTypeConfiguration<Wallets.Provider>
    {
        public void Configure(EntityTypeBuilder<Wallets.Provider> builder)
        {
            builder.HasData(
                    new Wallets.Provider
                    {
                        Id = 1,
                        Name = "Metamask"
                    });
            builder.HasData(
                    new Wallets.Provider
                    {
                        Id = 2,
                        Name = "Coinbase"
                    });

            builder.HasData(
                    new Wallets.Provider
                    {
                        Id = 3,
                        Name = "WalletConnect"
                    });
        }
    }
}
