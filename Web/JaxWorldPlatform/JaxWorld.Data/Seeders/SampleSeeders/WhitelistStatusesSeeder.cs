namespace JaxWorld.Data.Seeders.SampleSeeders
{
    using Constants;
    using Entities.Whitelists;

    internal static class WhitelistStatusesSeeder
    {
        internal static async Task Seed(JaxWorldDbContext context)
        {

            var open = new WhitelistStatus
            {
                Status = "Open",
                NormalizedTag = "Open".ToUpper(),
                CreatorId = CreatorParams.Id,
                CreationDate = DateTime.Now,
                LastModifierId = CreatorParams.Id,
                LastModificationDate = DateTime.Now
            };

            var closed = new WhitelistStatus
            {
                Status = "Closed",
                NormalizedTag = "Closed".ToUpper(),
                CreatorId = CreatorParams.Id,
                CreationDate = DateTime.Now,
                LastModifierId = CreatorParams.Id,
                LastModificationDate = DateTime.Now
            };

            var paused = new WhitelistStatus
            {
                Status = "Paused",
                NormalizedTag = "Paused".ToUpper(),
                CreatorId = CreatorParams.Id,
                CreationDate = DateTime.Now,
                LastModifierId = CreatorParams.Id,
                LastModificationDate = DateTime.Now
            };

            await context.WhitelistStatuses.AddRangeAsync(open, closed, paused);
            await context.SaveChangesAsync();
        }
    }
}
