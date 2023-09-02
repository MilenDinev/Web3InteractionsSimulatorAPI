namespace JaxWorld.Data.Seeders.SampleSeeders
{
    using Entities.Wallets;
    using Microsoft.EntityFrameworkCore;

    internal class WalletsSampleSeeder
    {
        internal static async Task Seed(JaxWorldDbContext context)
        {
            var avaxNetwork = await context.Networks.FindAsync(1);
            var AdminWallet = new Wallet
            {
                ProviderId = 1,
                Address = "0x72d0672Dc344F9389aF2Df418256A82F8BEFB",
                NormalizedTag = "0x72d0672Dc344F9389aF2Df418256A82F8BEFB".ToUpper(),
                Balance = 0.00m,
                OwnerId = 1,
                CreatorId = 1,
                CreationDate = DateTime.Now,
                LastModifierId = 1,
                LastModificationDate = DateTime.Now
            };

            AdminWallet.Networks.Add(avaxNetwork);

            await context.Wallets.AddAsync(AdminWallet);
            await context.SaveChangesAsync();
        }
    }
}
