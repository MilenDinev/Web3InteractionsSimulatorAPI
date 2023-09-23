namespace JaxWorld.Data.Seeders
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.AspNetCore.Identity;
    using System.Diagnostics.CodeAnalysis;
    using Microsoft.Extensions.DependencyInjection;
    using Entities;
    using EntitySeeders;
    using SampleSeeders;

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
                    await WhitelistStatusesSeeder.Seed(context);
                    await TransactionStateSeeder.Seed(context);
                    await TxnActionSeeder.Seed(context);
                    await ContractSeeder.Seed(context);
                }

            }
        }
    }
}
