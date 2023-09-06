namespace JaxWorld.Web.Controllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using Base;
    using Services.Main.Interfaces;
    using Models.Responses.BlockchainResponses.WalletModels;
    using Models.Requests.BlockchainRequests.WalletModels;
    using JaxWorld.Data.Entities.Wallets;

    // For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

    [Route("api/[controller]")]
    [ApiController]
    public class WalletsController : JaxWorldBaseController
    {
        private readonly IWalletService walletService;

        private readonly IMapper mapper;

        public WalletsController(IWalletService walletService,

            IMapper mapper,
            IUserService userService)
            : base(userService)
        {
            this.walletService = walletService;
            this.mapper = mapper;
        }

        // GET: api/<WalletsController>
        [HttpGet("List/")]
        public async Task<ActionResult<IEnumerable<WalletListingModel>>> Get()
        {
            var allWallets = await this.walletService.GetAllActiveAsync();

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

        // PUT api/<WalletsController>/5
        [HttpPut("Edit/Wallet/{walletId}")]
        public async Task<ActionResult<EditedWalletModel>> Edit(EditWalletModel walletInput, int walletId)
        {
            await AssignCurrentUserAsync();

            var updatedWallet = await this.walletService.EditAsync(walletInput, walletId, CurrentUser.Id);

            return updatedWallet;
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
