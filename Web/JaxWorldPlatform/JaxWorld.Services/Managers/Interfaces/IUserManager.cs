namespace JaxWorld.Services.Managers.Interfaces
{
    using Data.Entities;
    using Microsoft.AspNetCore.Identity;
    using System.Collections.Generic;
    using System.Security.Claims;
    using System.Threading.Tasks;

    public interface IUserManager
    {
        Task<IdentityResult> CreateAsync(User user, string password);
        Task<IdentityResult> UpdateAsync(User user);
        Task<IdentityResult> DeleteAsync(User user);
        Task<IdentityResult> AddToRoleAsync(User user, string role);
        Task<User?> GetUserAsync(ClaimsPrincipal claimsPrincipal);
        Task<User?> FindByNameAsync(string userName);
        Task<User?> FindByEmailAsync(string userName);
        Task<User?> FindByIdAsync(string id);
        Task<ICollection<User>> GetAllAsync();
        Task<bool> IsUserInRoleAsync(int userId, string roleId);
        Task<List<string>> GetUserRolesAsync(User user);
        Task<bool> ValidateUserCredentialsAsync(string userName, string password);
    }
}