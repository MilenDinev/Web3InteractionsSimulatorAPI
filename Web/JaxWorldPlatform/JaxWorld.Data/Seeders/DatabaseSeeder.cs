namespace JaxWorld.Data.Seeders
{
    using Entities;
    using EntitySeeders;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using SampleSeeders;
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Threading.Tasks;

    [ExcludeFromCodeCoverage]
    public static class DatabaseSeeder
    {
        public async static Task SeedAsync(IServiceProvider applicationServices)
        {
            using (IServiceScope serviceScope = applicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<JaxWorldDbContext>();
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole<int>>>();
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<User>>();

                await context.Database.MigrateAsync();

                if (!context.Users.Any())
                {
                    await RolesSeeder.SeedRolesAsync(roleManager);
                    await UsersSeeder.SeedUsersAsync(userManager);
                    await StandardSeeder.Seed(context);
                    await ProviderSeeder.Seed(context);
                    await NetworksSampleSeeder.Seed(context);
                    await WalletsSampleSeeder.Seed(context);
                    await TransactionStateSeeder.Seed(context);
                }

            }
        }
    }
}
