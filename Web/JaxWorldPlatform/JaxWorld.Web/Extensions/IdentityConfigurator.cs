namespace JaxWorld.Web.Extensions
{
    using Data;
    using Data.Entities;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.Extensions.DependencyInjection;

    public static class IdentityConfigurator
    {
        public static void AddIdentityCore(this IServiceCollection services)
        {
            services.AddIdentityCore<User>(options =>
            {
                options.Password.RequiredLength = 6;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
            })
            .AddRoles<IdentityRole<int>>()
            .AddEntityFrameworkStores<JaxWorldDbContext>();
        }
    }
}
