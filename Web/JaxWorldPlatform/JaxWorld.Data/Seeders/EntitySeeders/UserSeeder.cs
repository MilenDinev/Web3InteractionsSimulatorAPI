namespace JaxWorld.Data.Seeders.EntitySeeders
{
    using Microsoft.AspNetCore.Identity;
    using Entities;

    public static class UsersSeeder
    {
        public static async Task SeedUsersAsync(UserManager<User> userManager)
        {
            var adminUser = new User()
            {
                UserName = "admin",
                Email = "TheMostImportanAdminEmail@yahoo.com",
                NormalizedEmail = "TheMostImportanAdminEmail@yahoo.com".ToUpper(),
                EmailConfirmed = true,
                NormalizedUserName = "admin".ToUpper(),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                CreatorId = 1,
                CreationDate = DateTime.Now,
                LastModifierId = 1,
                LastModificationDate = DateTime.Now
            };

            await userManager.CreateAsync(adminUser, "adminpass");
            await userManager.AddToRoleAsync(adminUser, "admin");
        }
    }
}
