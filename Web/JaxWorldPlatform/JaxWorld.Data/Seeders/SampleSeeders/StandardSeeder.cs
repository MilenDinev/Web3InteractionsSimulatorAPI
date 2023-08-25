namespace JaxWorld.Data.Seeders.SampleSeeders
{
    using Entities;

    internal class StandardSeeder
    {
        internal static async Task Seed(JaxWorldDbContext context)
        {

            var Erc721Standard = new Standard
            {
                Name = "ERC721",
                NormalizedTag = "ERC721".ToUpper(),
                CreatorId = 1,
                LastModifierId = 1
            };

            var Erc721aStandard = new Standard
            {
                Name = "ERC721a",
                NormalizedTag = "ERC721a".ToUpper(),
                CreatorId = 1,
                LastModifierId = 1
            };

            var Erc20Standard = new Standard
            {
                Name = "ERC20",
                NormalizedTag = "ERC20".ToUpper(),
                CreatorId = 1,
                LastModifierId = 1
            };

            var Erc1155Standard = new Standard
            {
                Name = "ERC1155",
                NormalizedTag = "ERC1155".ToUpper(),
                CreatorId = 1,
                LastModifierId = 1
            };

            await context.Standards.AddRangeAsync(Erc721Standard, Erc721aStandard, Erc20Standard, Erc1155Standard);
            await context.SaveChangesAsync();
        }
    }
}
