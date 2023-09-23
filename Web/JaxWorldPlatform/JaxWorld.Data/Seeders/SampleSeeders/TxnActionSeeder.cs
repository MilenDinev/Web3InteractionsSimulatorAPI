namespace JaxWorld.Data.Seeders.SampleSeeders
{
    using Constants;
    using Entities.Transactions;

    internal static class TxnActionSeeder
    {
        internal static async Task Seed(JaxWorldDbContext context)
        {
            var deploy = new TxnAction
            {
                Operation = "Deploy",
                NormalizedTag = "Deploy".ToUpper(),
                CreatorId = CreatorParams.Id,
                CreationDate = DateTime.Now,
                LastModifierId = CreatorParams.Id,
                LastModificationDate = DateTime.Now,      
            };

            var claim = new TxnAction
            {
                Operation = "Claim",
                NormalizedTag = "Claim".ToUpper(),
                CreatorId = CreatorParams.Id,
                CreationDate = DateTime.Now,
                LastModifierId = CreatorParams.Id,
                LastModificationDate = DateTime.Now,
            };

            var mint = new TxnAction
            {
                Operation = "Mint",
                NormalizedTag = "Mint".ToUpper(),
                CreatorId = CreatorParams.Id,
                CreationDate = DateTime.Now,
                LastModifierId = CreatorParams.Id,
                LastModificationDate = DateTime.Now,
            };

            var transfer = new TxnAction
            {
                Operation = "Transfer",
                NormalizedTag = "Transfer".ToUpper(),
                CreatorId = CreatorParams.Id,
                CreationDate = DateTime.Now,
                LastModifierId = CreatorParams.Id,
                LastModificationDate = DateTime.Now,
            };

            await context.TxnActions.AddRangeAsync(deploy, mint, claim, transfer);
            await context.SaveChangesAsync();
        }
    }
}
