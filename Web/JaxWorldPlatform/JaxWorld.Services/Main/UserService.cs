namespace JaxWorld.Services.Main
{
    using System.Security.Claims;
    using AutoMapper;
    using Data;
    using Base;
    using Constants;
    using Exceptions;
    using Interfaces;
    using Data.Entities;
    using Managers.Interfaces;
    using Models.Requests.EntityRequests;
    using Models.Responses.EntityResponses.UserModels;

    public class UserService : BaseService<User>, IUserService
    {
        private readonly IUserManager userManager;
        private readonly IMapper mapper;

        public UserService(IUserManager userManager, JaxWorldDbContext dbContext, IMapper mapper) : base(dbContext)
        {
            this.userManager = userManager;
            this.mapper = mapper;
        }

        public async Task<User> GetCurrentUserAsync(ClaimsPrincipal principal)
        {
            return await userManager.GetUserAsync(principal);
        }

        public async Task<ICollection<UserListingModel>> GetAllUsersAsync()
        {
            var users = await userManager.GetAllAsync();
            var usersResponceDto = mapper.Map<ICollection<UserListingModel>>(users);
            return usersResponceDto.ToList();
        }

        public async Task<User> CreateAsync(CreateUserModel userInput)
        {

            var user = mapper.Map<User>(userInput);
            await userManager.CreateAsync(user, userInput.Password);
            await userManager.AddToRoleAsync(user, "regular");

            return user;
        }

        public async Task EditAsync(User user, EditUserModel userModel, int modifierId)
        {
            user.UserName = userModel.Username;
            user.NormalizedName = userModel.Username.ToUpper();

            user.NormalizedUserName = user.UserName.ToUpper();
            await SaveModificationAsync(user, modifierId);
        }

        public async Task DeleteAsync(User user, int modifierId)
        {
            await DeleteEntityAsync(user, modifierId);
        }

        public async Task<UserListingModel> ListUserByIdAsync(int userId)
        {
            return mapper.Map<UserListingModel>(await GetUserByIdAsync(userId));
        }

        private async Task<User> GetUserByIdAsync(int userId)
        {
            var user = await userManager.FindByIdAsync(userId.ToString())
                ?? throw new ResourceNotFoundException(string.Format(ErrorMessages.EntityIdDoesNotExist, nameof(User), userId));

            return user;
        }
    }
}
