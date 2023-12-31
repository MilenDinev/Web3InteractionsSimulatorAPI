﻿namespace JaxWorld.Data.Seeders.SampleSeeders
{
    using Entities;
    using Constants;

    internal static class StandardSeeder
    {
        internal static async Task Seed(JaxWorldDbContext context)
        {

            var erc721Standard = new Standard
            {
                Name = "ERC721",
                NormalizedTag = "ERC721".ToUpper(),
                CreatorId = CreatorParams.Id,
                CreationDate = DateTime.Now,
                LastModifierId = CreatorParams.Id,
                LastModificationDate = DateTime.Now
            };

            var erc721aStandard = new Standard
            {
                Name = "ERC721a",
                NormalizedTag = "ERC721a".ToUpper(),
                CreatorId = CreatorParams.Id,
                CreationDate = DateTime.Now,
                LastModifierId = CreatorParams.Id,
                LastModificationDate = DateTime.Now
            };

            var erc20Standard = new Standard
            {
                Name = "ERC20",
                NormalizedTag = "ERC20".ToUpper(),
                CreatorId = CreatorParams.Id,
                CreationDate = DateTime.Now,
                LastModifierId = CreatorParams.Id,
                LastModificationDate = DateTime.Now
            };

            var erc1155Standard = new Standard
            {
                Name = "ERC1155",
                NormalizedTag = "ERC1155".ToUpper(),
                CreatorId = CreatorParams.Id,
                CreationDate = DateTime.Now,
                LastModifierId = CreatorParams.Id,
                LastModificationDate = DateTime.Now
            };

            await context.Standards.AddRangeAsync(erc721Standard, erc721aStandard, erc20Standard, erc1155Standard);
            await context.SaveChangesAsync();
        }
    }
}
