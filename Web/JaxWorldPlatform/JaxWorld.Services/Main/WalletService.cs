namespace JaxWorld.Services.Main
{
    using AutoMapper;
    using Base;
    using Interfaces;
    using Handlers.Interfaces;
    using Data;
    using Data.Entities.Wallets;
    using Models.Requests.BlockchainRequests.WalletModels;
    using Models.Responses.BlockchainResponses.WalletModels;

    public class WalletService : BaseService<Wallet>, IWalletService
    {
        private readonly IFinder finder;
        private readonly IValidator validator;
        private readonly IMapper mapper;

        public WalletService(JaxWorldDbContext dbContext,
            IFinder finder,
            IValidator validator, 
            IMapper mapper) : base(dbContext)
        {
            this.finder = finder;
            this.validator = validator;
            this.mapper = mapper;
        }

        public async Task<CreatedWalletModel> CreateAsync(CreateWalletModel walletModel, int creatorId)
        {
            var wallet = await this.finder.FindByStringOrDefaultAsync<Wallet>(walletModel.Address);
            await this.validator.ValidateUniqueEntityAsync(wallet);

            var provider = await this.finder.FindByStringOrDefaultAsync<Provider>(walletModel.Provider)
                ?? await this.finder.FindByIdOrDefaultAsync<Provider>(int.Parse(walletModel.Provider));

            wallet = mapper.Map<Wallet>(walletModel);

            wallet.OwnerId = creatorId;
            wallet.Provider = provider;

            await CreateEntityAsync(wallet, creatorId);

            var createdWallet = mapper.Map<CreatedWalletModel>(wallet);

            return createdWallet;
        }

        public async Task<EditedWalletModel> EditAsync(EditWalletModel walletModel, int walletId, int modifierId)
        {
            var wallet = await this.finder.FindByIdOrDefaultAsync<Wallet>(walletId);
            await this.validator.ValidateTargetEntityAvailabilityAsync(wallet);

            wallet.Owner.UserName = walletModel.Owner;

            await SaveModificationAsync(wallet, modifierId);

            return mapper.Map<EditedWalletModel>(wallet);
        }

        public async Task<DeletedWalletModel> DeleteAsync(int walletId, int modifierId)
        {
            var wallet = await this.finder.FindByIdOrDefaultAsync<Wallet>(walletId);
            await this.validator.ValidateTargetEntityAvailabilityAsync(wallet);

            await DeleteEntityAsync(wallet, modifierId);

            return mapper.Map<DeletedWalletModel>(wallet);
        }

        public async Task<WalletListingModel> GetById(int walletId)
        {
            var wallet = await this.finder.FindByIdOrDefaultAsync<Wallet>(walletId);
            await this.validator.ValidateTargetEntityAvailabilityAsync(wallet);

            return mapper.Map<WalletListingModel>(wallet);
        }

        public async Task<IEnumerable<WalletListingModel>> GetAllActiveAsync()
        {
            var allWallets = await this.finder.GetAllActiveAsync<Wallet>();

            return mapper.Map<ICollection<WalletListingModel>>(allWallets).ToList();
        }
    }
}
