namespace JaxWorld.Services.Handlers
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Options;
    using Interfaces;
    using Data.Entities;

    public class JaxWorldUserManager : UserManager<User>, IUserManager
    {
        public JaxWorldUserManager(IUserStore<User> store,
           IOptions<IdentityOptions> optionsAccessor,
           IPasswordHasher<User> passwordHasher,
           IEnumerable<IUserValidator<User>> userValidators,
           IEnumerable<IPasswordValidator<User>> passwordValidators,
           ILookupNormalizer keyNormalizer,
           IdentityErrorDescriber errors,
           IServiceProvider services,
           ILogger<UserManager<User>> logger) :
           base(store,
           optionsAccessor,
           passwordHasher,
           userValidators,
           passwordValidators,
           keyNormalizer,
           errors,
           services,
           logger)
        {

        }


        public async Task<ICollection<User>> GetAllAsync()
        {
            return await Users.ToListAsync();
        }

        public async Task<List<string>> GetUserRolesAsync(User user)
        {
            return (await GetRolesAsync(user)).ToList();
        }

        public async Task<bool> IsUserInRoleAsync(int userId, string roleName)
        {
            var user = await FindByIdAsync(userId.ToString());
            return user != null && await IsInRoleAsync(user, roleName);
        }

        public async Task<bool> ValidateUserCredentialsAsync(string userName, string password)
        {
            var user = await FindByNameAsync(userName) ?? await FindByEmailAsync(userName);
            return user != null && await CheckPasswordAsync(user, password);
        }
    }
}
