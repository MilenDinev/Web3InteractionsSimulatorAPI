namespace JaxWorld.Web.Controllers.Base
{
    using Constants;
    using Data.Entities;
    using Microsoft.AspNetCore.Mvc;
    using Services.Main.Interfaces;

    // For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
    public class JaxWorldBaseController : ControllerBase
    {
        protected readonly IUserService userService;

        protected JaxWorldBaseController(IUserService userService)
        {
            this.userService = userService;
        }

        public User CurrentUser { get; private set; }

        [ApiExplorerSettings(IgnoreApi = true)]
        protected async Task<ActionResult> AssignCurrentUserAsync()
        {
            CurrentUser = await this.userService.GetCurrentUserAsync(User) ??
                throw new UnauthorizedAccessException(ErrorMessages.InvalidCredentials);

            return Ok();
        }
    }
}

