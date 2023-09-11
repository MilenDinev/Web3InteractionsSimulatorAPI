namespace JaxWorld.Data.Seeders.EntitySeeders
{
    using Microsoft.AspNetCore.Identity;
    using System;
    using System.Threading.Tasks;

    internal static class RolesSeeder
    {
        internal static async Task SeedRolesAsync(RoleManager<IdentityRole<int>> roleManager)
        {
            var adminRole = new IdentityRole<int>()
            {
                Name = "admin",
                NormalizedName = "admin".ToUpper(),
                ConcurrencyStamp = Guid.NewGuid().ToString("D")
            };
            await roleManager.CreateAsync(adminRole);

            var regularRole = new IdentityRole<int>()
            {
                Name = "regular",
                NormalizedName = "regular".ToUpper(),
                ConcurrencyStamp = Guid.NewGuid().ToString("D")
            };
            await roleManager.CreateAsync(regularRole);
        }
    }
}
