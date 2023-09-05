namespace JaxWorld.Data.Seeders.SampleSeeders
{
    using Entities.Wallets;

    internal class ProviderSeeder
    {
        internal static async Task Seed(JaxWorldDbContext context)
        {

            var Metamask = new Provider
            {
                Name = "Metamask",
                NormalizedTag = "Metamask".ToUpper(),
                CreatorId = 1,
                CreationDate = DateTime.Now,
                LastModifierId = 1,
                LastModificationDate = DateTime.Now
            };

            var Coinbase = new Provider
            {
                Name = "Coinbase",
                NormalizedTag = "Coinbase".ToUpper(),
                CreatorId = 1,
                CreationDate = DateTime.Now,
                LastModifierId = 1,
                LastModificationDate = DateTime.Now
            };

            var WalletConnect = new Provider
            {
                Name = "WalletConnect",
                NormalizedTag = "WalletConnect".ToUpper(),
                CreatorId = 1,
                CreationDate = DateTime.Now,
                LastModifierId = 1,
                LastModificationDate = DateTime.Now
            };

            var Unknown = new Provider
            {
                Name = "Unknown",
                NormalizedTag = "Unknown".ToUpper(),
                CreatorId = 1,
                CreationDate = DateTime.Now,
                LastModifierId = 1,
                LastModificationDate = DateTime.Now
            };

            await context.WalletProviders.AddRangeAsync(Metamask, Coinbase, WalletConnect, Unknown);
            await context.SaveChangesAsync();
        }
    }
}
