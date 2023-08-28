namespace JaxWorld.Web
{
    using System.Collections.Generic;
    using System.Security.Claims;
    using System.Threading.Tasks;
    using IdentityServer4.Models;
    using IdentityServer4.Validation;
    using Services.Managers.Interfaces;
    using Constants;

    public class PasswordValidator : IResourceOwnerPasswordValidator
    {
        private readonly IUserManager userManager;
        public PasswordValidator(IUserManager userManager)
        {
            this.userManager = userManager;
        }

        public async Task ValidateAsync(ResourceOwnerPasswordValidationContext context)
        {
            var user = await userManager.FindByNameAsync(context.UserName) ?? await userManager.FindByEmailAsync(context.UserName);

            if (user != null)
            {
                var authResult = await userManager.ValidateUserCredentials(context.UserName, context.Password);

                if (authResult)
                {
                    var roles = await userManager.GetUserRolesAsync(user);
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, user.UserName),
                        new Claim(ClaimTypes.Email, user.Email)
                    };

                    claims.AddRange(roles.Select(role => new Claim(ClaimTypes.Role, role)));

                    context.Result = new GrantValidationResult(subject: user.Id.ToString(), authenticationMethod: "password", claims: claims);
                    return;
                }
            }

            context.Result = new GrantValidationResult(TokenRequestErrors.InvalidGrant, ErrorMessages.InvalidCredentials);
        }
    }
}
