namespace JaxWorld.Data.Seeders.EntitySeeders
{
    using Entities;
    using Constants;
    using Microsoft.AspNetCore.Identity;

    internal static class UsersSeeder
    {
        internal static async Task SeedUsersAsync(UserManager<User> userManager)
        {
            var adminUser = new User()
            {
                UserName = "admin",
                WalletId = 1,
                Email = "TheMostImportanAdminEmail@yahoo.com",
                NormalizedEmail = "TheMostImportanAdminEmail@yahoo.com".ToUpper(),
                EmailConfirmed = true,
                NormalizedUserName = "admin".ToUpper(),
                NormalizedTag = "admin".ToUpper(),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                CreatorId = CreatorParams.Id,
                CreationDate = DateTime.Now,
                LastModifierId = CreatorParams.Id,
                LastModificationDate = DateTime.Now
            };

            await userManager.CreateAsync(adminUser, "adminpass");
            await userManager.AddToRoleAsync(adminUser, "admin");
        }
    }
}
