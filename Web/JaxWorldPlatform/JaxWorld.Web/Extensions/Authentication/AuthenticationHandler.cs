﻿namespace JaxWorld.Web.Extensions.Authentication
{
    using Constants;
    using Models.Responses;
    using Services.Main.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Text.Json;
    using System.Threading.Tasks;

    public static class AuthenticationHandler
    {
        public static async Task<TokenModel> GetEligibilityTokenAsync(this IUserService userService, HttpClient client, string usernameInput, string passwordInput)
        {
            var tokenBaseAddress = IdentityServerConfigValues.TokenBaseAddress;

            var username = usernameInput;
            var password = passwordInput;
            var grantType = IdentityServerConfigValues.GrantType;
            var clientId = IdentityServerConfigValues.ClientId;
            var clientSecret = IdentityServerConfigValues.SecretValue;
            var form = new Dictionary<string, string>
                {
                    {"username", username},
                    {"password", password },
                    {"grant_type", grantType},
                    {"client_id", clientId},
                    {"client_secret", clientSecret},
                };

            var tokenResponse = await client.PostAsync(tokenBaseAddress, new FormUrlEncodedContent(form));
            var jsonContent = await tokenResponse.Content.ReadAsStringAsync();
            var token = JsonSerializer.Deserialize<TokenModel>(jsonContent);

            if (token.AccessToken == null)
            {
                throw new UnauthorizedAccessException(ErrorMessages.InvalidCredentials);
            }

            return token;
        }
    }
}
