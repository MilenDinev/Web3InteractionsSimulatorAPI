namespace JaxWorld.Web.Controllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using Base;
    using Services.Main.Interfaces;
    using Services.Managers.Interfaces;
    using Models.Requests.EntityRequests;
    using Models.Responses.EntityResponses.UserModels;

    // For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : JaxWorldBaseController
    {
        private readonly IUserManager userManager;
        private readonly IMapper mapper;

        public UsersController(IUserManager userManager,
            IMapper mapper,
            IUserService userService)
            : base(userService)
        {
            this.userManager = userManager;
            this.mapper = mapper;
        }

        [HttpGet("List/")]
        public async Task<ActionResult<IEnumerable<UserListingModel>>> Get()
        {
            var allUsers = await this.userService.GetAllActiveAsync();

            return allUsers.ToList();
        }

        [HttpGet("Get/User/{userId}")]
        public async Task<ActionResult<UserListingModel>> GetById(int userId)
        {
            var user = await userService.GetByIdAsync(userId);

            return mapper.Map<UserListingModel>(user);
        }

        [HttpPost("Register/")]
        public async Task<ActionResult> Create(CreateUserModel userInput)
        {
            var createdUser = await this.userService.CreateAsync(userInput);

            return CreatedAtAction(nameof(Get), "Users", new { id = createdUser.Id }, createdUser);
        }

        [HttpPut("Edit/User/{userId}")]
        public async Task<ActionResult<EditedUserModel>> Edit(EditUserModel userInput, int userId)
        {
            await AssignCurrentUserAsync();

            var editedUser = await this.userService.EditAsync(userInput, userId, CurrentUser.Id);

            return editedUser;
        }

        [HttpDelete("Delete/User/{userId}")]
        public async Task<DeletedUserModel> Delete(int userId)
        {
            await AssignCurrentUserAsync();

            var deletedUser = await this.userService.DeleteAsync(userId, CurrentUser.Id);

            return deletedUser;
        }
    }
}
