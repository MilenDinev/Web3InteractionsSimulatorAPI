﻿namespace JaxWorld.Web.Extensions
{
    using Microsoft.Extensions.DependencyInjection;
    using Web;

    public static class IdentityServerBuilder
    {
        public static IIdentityServerBuilder BuildIdentityServer(this IServiceCollection services)
        {
            var builder = services.AddIdentityServer((options) =>
            {
                options.EmitStaticAudienceClaim = true;
            })
             .AddInMemoryApiScopes(IdentityServerConfig.ApiScopes)
             .AddInMemoryClients(IdentityServerConfig.Clients);

            builder.AddDeveloperSigningCredential();
            builder.AddResourceOwnerValidator<PasswordValidator>();

            return builder;
        }

    }
}
