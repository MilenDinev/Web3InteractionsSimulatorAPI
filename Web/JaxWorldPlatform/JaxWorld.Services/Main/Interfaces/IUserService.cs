namespace JaxWorld.Services.Main.Interfaces
{
    using System.Security.Claims;
    using Data.Entities;
    using Models.Requests.EntityRequests;
    using Models.Responses.EntityResponses.UserModels;

    internal interface IUserService
    {
        Task<User> CreateAsync(CreateUserModel userRequestModel);
        Task EditAsync(User user, EditUserModel userModel, int modifierId);
        Task DeleteAsync(User user, int modifierId);
        Task SaveModificationAsync(User user, int modifierId);
        Task<User> GetCurrentUserAsync(ClaimsPrincipal principal);
        Task<UserListingModel> ListUserByIdAsync(int userId);
        Task<ICollection<UserListingModel>> GetAllUsersAsync();
    }
}
