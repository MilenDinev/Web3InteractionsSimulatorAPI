namespace JaxWorld.Services.Main
{
    using AutoMapper;
    using System.Security.Claims;
    using Base;
    using Constants;
    using Interfaces;
    using Handlers.Exceptions;
    using Handlers.Interfaces;
    using Data;
    using Data.Entities;
    using Models.Requests.EntityRequests;
    using Models.Responses.EntityResponses.UserModels;

    public class UserService : BaseService<User>, IUserService
    {
        private readonly IUserManager userManager;
        private readonly IMapper mapper;

        public UserService(IUserManager userManager,
            IMapper mapper,
            JaxWorldDbContext dbContext) : base(dbContext)
        {
            this.userManager = userManager;
            this.mapper = mapper;
        }

        public async Task<CreatedUserModel> CreateAsync(CreateUserModel userInput)
        {
            await this.ValidateCreateInputAsync(userInput.UserName);

            var user = mapper.Map<User>(userInput);

            await userManager.CreateAsync(user, userInput.Password);
            await userManager.AddToRoleAsync(user, "regular");

            return mapper.Map<CreatedUserModel>(user);
        }

        public async Task<EditedUserModel> EditAsync(EditUserModel userModel, int userId, int modifierId)
        {
            var user = await this.userManager.FindByIdAsync(userId.ToString());

            if (user != null)
            {

                user.UserName = userModel.UserName;
                user.NormalizedTag = userModel.UserName?.ToUpper() ?? user.NormalizedTag;
                user.NormalizedUserName = user.UserName?.ToUpper() ?? user.NormalizedUserName;

                await SaveModificationAsync(user, modifierId);

                return mapper.Map<EditedUserModel>(user);

            }

            throw new ResourceAlreadyExistsException(string.Format(ErrorMessages.EntityDoesNotExist, typeof(User).Name));
        }

        public async Task<DeletedUserModel> DeleteAsync(int userId, int modifierId)
        {
            var user = await this.userManager.FindByIdAsync(userId.ToString());

            if (user != null)
            {
                await DeleteEntityAsync(user, modifierId);
                return mapper.Map<DeletedUserModel>(user);
            }

            throw new ResourceAlreadyExistsException(string.Format(ErrorMessages.EntityDoesNotExist, typeof(User).Name));

        }

        public async Task<User> GetCurrentUserAsync(ClaimsPrincipal principal)
        {
            return await userManager.GetUserAsync(principal);
        }

        public async Task<UserListingModel> GetByIdAsync(int userId)
        {
            var user = await userManager.FindByIdAsync(userId.ToString())
                ?? throw new ResourceNotFoundException(string.Format(ErrorMessages.EntityDoesNotExist, nameof(User), userId));

            return mapper.Map<UserListingModel>(user);
        }

        public async Task<IEnumerable<UserListingModel>> GetAllActiveUsersAsync()
        {
            var allActiveUsers = await userManager.GetAllAsync();

            return mapper.Map<ICollection<UserListingModel>>(allActiveUsers.Where(x => !x.Deleted)).ToList();
        }

        public async Task<ICollection<UserListingModel>> GetAllUsersAsync()
        {
            var users = await userManager.GetAllAsync();
            var usersResponceDto = mapper.Map<ICollection<UserListingModel>>(users);
            return usersResponceDto.ToList();
        }

        private async Task ValidateCreateInputAsync(string userName)
        {
            var user = await userManager.FindByNameAsync(userName);
            if (user != null)
                throw new ResourceAlreadyExistsException(string.Format(
                    ErrorMessages.NamedEntityAlreadyExists,
                    typeof(User).Name, userName));

            user = await userManager.FindByEmailAsync(userName);
            if (user != null)
                throw new ResourceAlreadyExistsException(string.Format(ErrorMessages.EntityAlreadyExists, typeof(User).Name));
        }
    }
}
