namespace JaxWorld.Data.Seeders.SampleSeeders
{
    using Constants;
    using Entities.Transactions;

    internal static class TransactionStateSeeder
    {
        internal static async Task Seed(JaxWorldDbContext context)
        {

            var pending = new TransactionState
            {
                State = "Pending",
                NormalizedTag = "Pending".ToUpper(),
                CreatorId = CreatorParams.Id,
                CreationDate = DateTime.Now,
                LastModifierId = CreatorParams.Id,   
                LastModificationDate = DateTime.Now
            };

            var confirmed = new TransactionState
            {
                State = "Confirmed",
                NormalizedTag = "Confirmed".ToUpper(),
                CreatorId = CreatorParams.Id,
                CreationDate = DateTime.Now,
                LastModifierId = CreatorParams.Id,
                LastModificationDate = DateTime.Now
            };

            var rejected = new TransactionState
            {
                State = "Rejected",
                NormalizedTag = "Rejected".ToUpper(),
                CreatorId = CreatorParams.Id,
                CreationDate = DateTime.Now,
                LastModifierId = CreatorParams.Id,
                LastModificationDate = DateTime.Now
            };

            await context.TransactionStates.AddRangeAsync(pending, confirmed, rejected);
            await context.SaveChangesAsync();
        }
    }
}
