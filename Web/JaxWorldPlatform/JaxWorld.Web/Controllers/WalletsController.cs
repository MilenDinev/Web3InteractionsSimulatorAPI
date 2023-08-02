namespace JaxWorld.Web.Controllers
{
    using AutoMapper;
    using Base;
    using Microsoft.AspNetCore.Mvc;
    using Services.Main.Interfaces;
    using Services.Handlers.Interfaces;
    using Data.Entities.Blockchain.Wallets;
    using Models.Responses.BlockchainResponses.WalletModels;
    using Models.Requests.BlockchainRequests.WalletModels;

    // For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860


    [Route("api/[controller]")]
    [ApiController]
    public class WalletsController : JaxWorldBaseController
    {
        private readonly IWalletService walletService;
        private readonly IFinder finder;
        private readonly IValidator validator;
        private readonly IMapper mapper;

        public WalletsController(IWalletService walletService,
            IFinder finder,
            IValidator validator,
            IMapper mapper,
            IUserService userService)
            : base(userService)
        {
            this.walletService = walletService;
            this.finder = finder;
            this.validator = validator;
            this.mapper = mapper;
        }

        // GET: api/<WalletsController>
        [HttpGet("List/")]
        public async Task<ActionResult<IEnumerable<WalletListingModel>>> Get()
        {
            var allWallets = await this.finder.GetAllActiveAsync<Wallet>();
            return mapper.Map<ICollection<WalletListingModel>>(allWallets).ToList();
        }

        // GET api/<WalletsController>/Wallet/5
        [HttpGet("Get/Wallet/{walletId}")]
        public async Task<ActionResult<WalletListingModel>> GetById(int walletId)
        {
            var wallet = await this.finder.FindByIdOrDefaultAsync<Wallet>(walletId);
            await this.validator.ValidateEntityAsync(wallet, walletId.ToString());
            return mapper.Map<WalletListingModel>(wallet);
        }

        // POST api/<WalletsController/Add>
        [HttpPost("Add/")]
        public async Task<ActionResult> Create(CreateWalletModel walletInput)
        {
            await AssignCurrentUserAsync();
            var wallet = await this.finder.FindByStringOrDefaultAsync<Wallet>(walletInput.Address);
            await this.validator.ValidateUniqueEntityAsync(wallet);

            wallet = await this.walletService.CreateAsync(walletInput, CurrentUser.Id);
            var createdWallet = mapper.Map<CreatedWalletModel>(wallet);

            return CreatedAtAction(nameof(Get), "Wallets", new { id = createdWallet.Id }, createdWallet);
        }

        // PUT api/<WalletsController>/5
        [HttpPut("Edit/Wallet/{walletId}")]
        public async Task<ActionResult<EditedWalletModel>> Edit(EditWalletModel walletInput, int walletId)
        {
            await AssignCurrentUserAsync();

            var wallet = await this.finder.FindByIdOrDefaultAsync<Wallet>(walletId);
            await this.validator.ValidateEntityAsync(wallet, walletId.ToString());

            await this.walletService.EditAsync(wallet, walletInput, CurrentUser.Id);

            return mapper.Map<EditedWalletModel>(wallet);
        }

        // DELETE api/<WalletsController>/Wallet/5
        [HttpDelete("Delete/Wallet/{walletId}")]
        public async Task<DeletedWalletModel> Delete(int walletId)
        {
            await AssignCurrentUserAsync();
            var wallet = await this.finder.FindByIdOrDefaultAsync<Wallet>(walletId);
            await this.validator.ValidateEntityAsync(wallet, walletId.ToString());
            await this.walletService.DeleteAsync(wallet, CurrentUser.Id);
            return mapper.Map<DeletedWalletModel>(wallet);
        }
    }
}
