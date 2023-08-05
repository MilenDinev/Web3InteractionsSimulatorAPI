namespace JaxWorld.Web.Constants
{
    public static class IdentityServerConfigValues
    {
        public const string UrlAddress = @"https://localhost:7054";
        public const string ResourcesUrlAddress = @"https://localhost:7054/resources";
        public const string TokenBaseAddress = @"https://localhost:7054/connect/token";
        public const string ClientId = "jaxworld";
        public const string SecretValue = "secret";
        public const string GrantType = "password";
        public const bool AllowOfflineAccess = true;
    }
}
