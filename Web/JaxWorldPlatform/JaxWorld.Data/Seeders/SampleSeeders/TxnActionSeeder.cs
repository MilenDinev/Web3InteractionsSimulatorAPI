namespace JaxWorld.Data.Seeders.SampleSeeders
{
    using Entities.Transactions;

    internal static class TxnActionSeeder
    {
        internal static async Task Seed(JaxWorldDbContext context)
        {
            var deploy = new TxnAction
            {
                Operation = "Deploy",
                NormalizedTag = "Deploy".ToUpper(),
                CreatorId = 1,
                CreationDate = DateTime.Now,
                LastModifierId = 1,
                LastModificationDate = DateTime.Now,      
            };

            var claim = new TxnAction
            {
                Operation = "Claim",
                NormalizedTag = "Claim".ToUpper(),
                CreatorId = 1,
                CreationDate = DateTime.Now,
                LastModifierId = 1,
                LastModificationDate = DateTime.Now,
            };

            var mint = new TxnAction
            {
                Operation = "Mint",
                NormalizedTag = "Mint".ToUpper(),
                CreatorId = 1,
                CreationDate = DateTime.Now,
                LastModifierId = 1,
                LastModificationDate = DateTime.Now,
            };

            var transfer = new TxnAction
            {
                Operation = "Transfer",
                NormalizedTag = "Transfer".ToUpper(),
                CreatorId = 1,
                CreationDate = DateTime.Now,
                LastModifierId = 1,
                LastModificationDate = DateTime.Now,
            };

            await context.TxnActions.AddRangeAsync(deploy, mint, claim, transfer);
            await context.SaveChangesAsync();
        }
    }
}
