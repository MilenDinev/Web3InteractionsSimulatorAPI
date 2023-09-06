namespace JaxWorld.Services.Main.Interfaces
{
    using System.Security.Claims;
    using Data.Entities;
    using Models.Requests.EntityRequests;
    using Models.Responses.EntityResponses.UserModels;

    public interface IUserService
    {
        Task<User> GetCurrentUserAsync(ClaimsPrincipal principal);
        Task<UserListingModel> GetByIdAsync(int userId);
        Task<ICollection<UserListingModel>> GetAllUsersAsync();
        Task<IEnumerable<UserListingModel>> GetAllActiveAsync();
        Task<CreatedUserModel> CreateAsync(CreateUserModel userInput);
        Task<EditedUserModel> EditAsync(EditUserModel userModel, int userId, int modifierId);
        Task<DeletedUserModel> DeleteAsync(int userId, int modifierId);
    }
}
