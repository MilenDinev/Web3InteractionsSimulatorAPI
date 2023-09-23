namespace JaxWorld.Data.Seeders.SampleSeeders
{
    using Entities.Wallets;
    using Constants;

    internal static class ProviderSeeder
    {
        internal static async Task Seed(JaxWorldDbContext context)
        {

            var metamask = new Provider
            {
                Name = "Metamask",
                NormalizedTag = "Metamask".ToUpper(),
                CreatorId = CreatorParams.Id,
                CreationDate = DateTime.Now,
                LastModifierId = CreatorParams.Id,
                LastModificationDate = DateTime.Now
            };

            var coinbase = new Provider
            {
                Name = "Coinbase",
                NormalizedTag = "Coinbase".ToUpper(),
                CreatorId = CreatorParams.Id,
                CreationDate = DateTime.Now,
                LastModifierId = CreatorParams.Id,
                LastModificationDate = DateTime.Now
            };

            var walletConnect = new Provider
            {
                Name = "WalletConnect",
                NormalizedTag = "WalletConnect".ToUpper(),
                CreatorId = CreatorParams.Id,
                CreationDate = DateTime.Now,
                LastModifierId = CreatorParams.Id,
                LastModificationDate = DateTime.Now
            };

            var unknown = new Provider
            {
                Name = "Unknown",
                NormalizedTag = "Unknown".ToUpper(),
                CreatorId = CreatorParams.Id,
                CreationDate = DateTime.Now,
                LastModifierId = CreatorParams.Id,
                LastModificationDate = DateTime.Now
            };

            await context.WalletProviders.AddRangeAsync(metamask, coinbase, walletConnect, unknown);
            await context.SaveChangesAsync();
        }
    }
}
