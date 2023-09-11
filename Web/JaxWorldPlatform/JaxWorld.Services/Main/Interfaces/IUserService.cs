namespace JaxWorld.Services.Main.Interfaces
{
    using Data.Entities;
    using Models.Requests.EntityRequests;
    using Models.Responses.EntityResponses.UserModels;
    using System.Security.Claims;

    public interface IUserService
    {
        Task<User> GetCurrentUserAsync(ClaimsPrincipal principal);
        Task<UserListingModel> GetByIdAsync(int userId);
        Task<ICollection<UserListingModel>> GetAllUsersAsync();
        Task<IEnumerable<UserListingModel>> GetAllActiveUsersAsync();
        Task<CreatedUserModel> CreateAsync(CreateUserModel userInput);
        Task<EditedUserModel> EditAsync(EditUserModel userModel, int userId, int modifierId);
        Task<DeletedUserModel> DeleteAsync(int userId, int modifierId);
    }
}
