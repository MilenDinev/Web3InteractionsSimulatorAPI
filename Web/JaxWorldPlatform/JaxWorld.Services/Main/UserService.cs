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
    using Handlers.Interfaces;
    using Models.Requests.EntityRequests;
    using Models.Responses.EntityResponses.UserModels;

    public class UserService : BaseService<User>, IUserService
    {
        private readonly IUserManager userManager;
        private readonly IFinder finder;
        private readonly IValidator validator;
        private readonly IMapper mapper;

        public UserService(IUserManager userManager,
            IFinder finder,
            IValidator validator,
            IMapper mapper,
            JaxWorldDbContext dbContext) : base(dbContext)
        {
            this.userManager = userManager;
            this.finder = finder;
            this.validator = validator;
            this.mapper = mapper;
        }

        public async Task<User> GetCurrentUserAsync(ClaimsPrincipal principal)
        {
            return await userManager.GetUserAsync(principal);
        }

        public async Task<UserListingModel> GetByIdAsync(int userId)
        {
            var user = await userManager.FindByIdAsync(userId.ToString())
                ?? throw new ResourceNotFoundException(string.Format(ErrorMessages.EntityIdDoesNotExist, nameof(User), userId));

            return mapper.Map<UserListingModel>(user);
        }

        public async Task<IEnumerable<UserListingModel>> GetAllActiveAsync()
        {
            var allActiveUsers = await this.finder.GetAllActiveAsync<User>();

            return mapper.Map<ICollection<UserListingModel>>(allActiveUsers).ToList();
        }

        public async Task<ICollection<UserListingModel>> GetAllUsersAsync()
        {
            var users = await userManager.GetAllAsync();
            var usersResponceDto = mapper.Map<ICollection<UserListingModel>>(users);
            return usersResponceDto.ToList();
        }

        public async Task<CreatedUserModel> CreateAsync(CreateUserModel userInput)
        {
            var user = await userManager.FindByNameAsync(userInput.UserName);
            await this.validator.ValidateUniqueEntityAsync(user);

            user = await userManager.FindByEmailAsync(userInput.UserName);
            if (user != null)
                throw new ResourceAlreadyExistsException(string.Format(ErrorMessages.EntityAlreadyExists, nameof(userInput.WalletAddress), userInput.WalletAddress));

            user = mapper.Map<User>(userInput);

            await userManager.CreateAsync(user, userInput.Password);
            await userManager.AddToRoleAsync(user, "regular");

            return mapper.Map<CreatedUserModel>(user);
        }

        public async Task<EditedUserModel> EditAsync(EditUserModel userModel, int userId, int modifierId)
        {
            var user = await this.finder.FindByIdOrDefaultAsync<User>(userId);

            await this.validator.ValidateTargetEntityAvailabilityAsync(user);

            user.UserName = userModel.UserName;
            user.NormalizedTag = userModel.UserName.ToUpper();
            user.NormalizedUserName = user.UserName.ToUpper();

            await SaveModificationAsync(user, modifierId);

            return mapper.Map<EditedUserModel>(user);
        }

        public async Task<DeletedUserModel> DeleteAsync(int userId, int modifierId)
        {
            var user = await this.finder.FindByIdOrDefaultAsync<User>(userId);

            await this.validator.ValidateTargetEntityAvailabilityAsync(user);
            await DeleteEntityAsync(user, modifierId);

            return mapper.Map<DeletedUserModel>(user);
        }

    }
}
