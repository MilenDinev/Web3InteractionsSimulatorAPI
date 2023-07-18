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
            };

            await userManager.CreateAsync(adminUser, "adminpass");
            await userManager.AddToRoleAsync(adminUser, "admin");
        }
    }
}
