namespace JaxWorld.Web.Controllers.Base
{
    using Constants;
    using Data.Entities;
    using Services.Main.Interfaces;
    using Microsoft.AspNetCore.Mvc;

    // For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
    public class JaxWorldBaseController : ControllerBase
    {
        protected readonly IUserService userService;

        protected JaxWorldBaseController(IUserService userService)
        {
            this.userService = userService;
        }

        public User CurrentUser { get; set; }

        [ApiExplorerSettings(IgnoreApi = true)]
        protected async Task<ActionResult> AssignCurrentUserAsync()
        {
            CurrentUser = await this.userService.GetCurrentUserAsync(User) ??
                throw new UnauthorizedAccessException(ErrorMessages.InvalidCredentials);

            return Ok();
        }
    }
}

