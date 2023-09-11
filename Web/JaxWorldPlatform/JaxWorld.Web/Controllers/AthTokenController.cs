namespace JaxWorld.Web.Controllers
{
    using Base;
    using Extensions.Authentication;
    using Microsoft.AspNetCore.Mvc;
    using Models.Requests.EntityRequests;
    using Models.Responses;
    using Services.Main.Interfaces;

    [Route("api/[controller]")]
    [ApiController]
    public class AthTokenController : JaxWorldBaseController
    {
        public AthTokenController(IUserService userService) : base(userService)
        {
        }

        /// <summary>
        /// Generate token given valid credentials
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost("GenerateToken/")]
        public async Task<ActionResult<TokenModel>> GenerateToken(UserTokenRequestModel user)
        {
            using var httpClientHandler = new HttpClientHandler();
            using var client = new HttpClient(httpClientHandler);
            var token = await this.userService.GetEligibilityTokenAsync(client, user.UsernameOrEmail, user.Password);

            return token;
        }
    }
}
