namespace JaxWorld.Data.Seeders.SampleSeeders
{
    using Constants;
    using Entities.Wallets;

    internal static class WalletsSampleSeeder
    {
        internal static async Task Seed(JaxWorldDbContext context)
        {
            var avaxNetwork = await context.Networks.FindAsync(1);
            var adminWallet = new Wallet
            {
                ProviderId = 1,
                Address = "0x72d0672Dc344F9389aF2Df418256A82F8BEFB",
                NormalizedTag = "0x72d0672Dc344F9389aF2Df418256A82F8BEFB".ToUpper(),
                Balance = 1.36m,
                OwnerId = 1,
                CreatorId = CreatorParams.Id,
                CreationDate = DateTime.Now,
                LastModifierId = CreatorParams.Id,
                LastModificationDate = DateTime.Now
            };

            adminWallet.Networks.Add(avaxNetwork);

            await context.Wallets.AddAsync(adminWallet);
            await context.SaveChangesAsync();
        }
    }
}
