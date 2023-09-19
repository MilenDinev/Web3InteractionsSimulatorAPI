namespace JaxWorld.Data.Seeders.SampleSeeders
{
    using Entities.Wallets;

    internal class ProviderSeeder
    {
        internal static async Task Seed(JaxWorldDbContext context)
        {

            var metamask = new Provider
            {
                Name = "Metamask",
                NormalizedTag = "Metamask".ToUpper(),
                CreatorId = 1,
                CreationDate = DateTime.Now,
                LastModifierId = 1,
                LastModificationDate = DateTime.Now
            };

            var coinbase = new Provider
            {
                Name = "Coinbase",
                NormalizedTag = "Coinbase".ToUpper(),
                CreatorId = 1,
                CreationDate = DateTime.Now,
                LastModifierId = 1,
                LastModificationDate = DateTime.Now
            };

            var walletConnect = new Provider
            {
                Name = "WalletConnect",
                NormalizedTag = "WalletConnect".ToUpper(),
                CreatorId = 1,
                CreationDate = DateTime.Now,
                LastModifierId = 1,
                LastModificationDate = DateTime.Now
            };

            var unknown = new Provider
            {
                Name = "Unknown",
                NormalizedTag = "Unknown".ToUpper(),
                CreatorId = 1,
                CreationDate = DateTime.Now,
                LastModifierId = 1,
                LastModificationDate = DateTime.Now
            };

            await context.WalletProviders.AddRangeAsync(metamask, coinbase, walletConnect, unknown);
            await context.SaveChangesAsync();
        }
    }
}
