﻿namespace JaxWorld.Web.Constants
{
    public static class SwaggerConfigValues
    {
        public const string SwaggerDocVersion = "v1";
        public const string SecurityDefinitionName = "Bearer";
        public const string EndpointUrl = "/swagger/v1/swagger.json";
        public const string EndpointName = "JaxWorld.Web v1";
        public const string OpenApiInfoTitle = "JaxWorld.Web";
        public const string OpenApiInfoVersion = "v1";
        public const string OpenApiInfoDescription = "JaxWorld API";
        public const string OpenApiSecuritySchemeDescription = @"JWT Authorization header using the Bearer scheme.
                                                               Example: \Authorization: Bearer {token}\";
        public const string OpenApiSecuritySchemeName = "Authorization";
        public const string OpenApiId = "Bearer";
        public const string OpenApiScheme = "oauth2";
        public const string OpenApiName = "Bearer";
    }
}
