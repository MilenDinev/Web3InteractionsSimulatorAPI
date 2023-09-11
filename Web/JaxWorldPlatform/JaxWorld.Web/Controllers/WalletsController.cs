namespace JaxWorld.Web.Controllers
{
    using Base;
    using Microsoft.AspNetCore.Mvc;
    using Models.Requests.BlockchainRequests.WalletModels;
    using Models.Responses.BlockchainResponses.WalletModels;
    using Services.Main.Interfaces;

    // For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

    [Route("api/[controller]")]
    [ApiController]
    public class WalletsController : JaxWorldBaseController
    {
        private readonly IWalletService walletService;

        public WalletsController(IWalletService walletService,
            IUserService userService)
            : base(userService)
        {
            this.walletService = walletService;
        }

        // GET: api/<WalletsController>
        [HttpGet("List/")]
        public async Task<ActionResult<IEnumerable<WalletListingModel>>> Get()
        {
            var allWallets = await this.walletService.GetAllActiveWalletsAsync();

            return allWallets.ToList();
        }

        // GET api/<WalletsController>/Wallet/5
        [HttpGet("Get/Wallet/{walletId}")]
        public async Task<ActionResult<WalletListingModel>> GetById(int walletId)
        {
            var walletListingModel = await this.walletService.GetById(walletId);

            return walletListingModel;
        }

        // POST api/<WalletsController/Add>
        [HttpPost("Add/")]
        public async Task<ActionResult> Create(CreateWalletModel walletInput)
        {
            await AssignCurrentUserAsync();

            var createdWallet = await this.walletService.CreateAsync(walletInput, CurrentUser.Id);

            return CreatedAtAction(nameof(Get), "Wallets", new { id = createdWallet.Id }, createdWallet);
        }

        // DELETE api/<WalletsController>/Wallet/5
        [HttpDelete("Delete/Wallet/{walletId}")]
        public async Task<DeletedWalletModel> Delete(int walletId)
        {
            await AssignCurrentUserAsync();

            var deletedWalletModel = await this.walletService.DeleteAsync(walletId, CurrentUser.Id);

            return deletedWalletModel;
        }
    }
}
