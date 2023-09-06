namespace JaxWorld.Web.Extensions.Authentication
{
    using Constants;
    using Microsoft.AspNetCore.Authentication.JwtBearer;

    public static class AuthenticationConfigurator
    {
        public static void AddAuthenticationConfig(this IServiceCollection services)
        {
            services.AddAuthentication(options =>
            {
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(options =>
                {
                    options.Authority = IdentityServerConfigValues.UrlAddress;
                    options.Audience = IdentityServerConfigValues.ResourcesUrlAddress;
                });
        }
    }
}
