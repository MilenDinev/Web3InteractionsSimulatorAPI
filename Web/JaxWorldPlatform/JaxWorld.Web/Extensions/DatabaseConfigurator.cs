namespace JaxWorld.Web.Extensions
{
    using Microsoft.EntityFrameworkCore;
    using Data;

    public static class DatabaseConfigurator
    {
        public static void AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<JaxWorldDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("Default")));
        }
    }
}
