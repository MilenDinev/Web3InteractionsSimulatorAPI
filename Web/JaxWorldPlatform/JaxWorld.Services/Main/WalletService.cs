namespace JaxWorld.Services.Main
{
    using AutoMapper;
    using System.Collections.Generic;
    using Base;
    using Constants;
    using Interfaces;
    using Handlers.Exceptions;
    using Handlers.Interfaces;
    using Data;
    using Data.Entities.Wallets;
    using Models.Requests.BlockchainRequests.WalletModels;
    using Models.Responses.BlockchainResponses.WalletModels;

    public class WalletService : BaseService<Wallet>, IWalletService
    {
        private readonly IFinder finder;
        private readonly IMapper mapper;

        public WalletService(JaxWorldDbContext dbContext,
            IFinder finder,
            IMapper mapper) : base(dbContext)
        {
            this.finder = finder;
            this.mapper = mapper;
        }

        public async Task<CreatedWalletModel> CreateAsync(CreateWalletModel walletModel, int creatorId)
        {
            await this.ValidateWalletCreateInputAsync(walletModel.Address);

            var wallet = mapper.Map<Wallet>(walletModel);

            wallet.OwnerId = creatorId;

            await CreateEntityAsync(wallet, creatorId);

            var createdWallet = mapper.Map<CreatedWalletModel>(wallet);

            return createdWallet;
        }

        public async Task<DeletedWalletModel> DeleteAsync(int walletId, int modifierId)
        {
            var wallet = await this.GetWalletAsync(walletId);

            await DeleteEntityAsync(wallet, modifierId);

            return mapper.Map<DeletedWalletModel>(wallet);
        }

        public async Task<WalletListingModel> GetById(int walletId)
        {
            var wallet = await this.GetWalletAsync(walletId);

            return mapper.Map<WalletListingModel>(wallet);
        }

        public async Task<IEnumerable<WalletListingModel>> GetAllActiveWalletsAsync()
        {
            var allWallets = await this.finder.GetAllAsync<Wallet>();

            return mapper.Map<ICollection<WalletListingModel>>(allWallets.Where(x => !x.Deleted)).ToList();
        }

        private async Task<Wallet> GetWalletAsync(int walletId)
        {
            var wallet = await this.finder.FindByIdOrDefaultAsync<Wallet>(walletId);

            if (wallet != null)
                return wallet;

            throw new ResourceNotFoundException(string.Format(
                ErrorMessages.EntityDoesNotExist, typeof(Wallet).Name));
        }

        private async Task ValidateWalletCreateInputAsync(string walletAddress)
        {
            var wallet = await this.finder.AnyByStringAsync<Wallet>(walletAddress);

            if (wallet)
                throw new ResourceAlreadyExistsException(string.Format(
                    ErrorMessages.AddresableEntityAlreadyExists,
                    typeof(Wallet).Name, walletAddress));
        }

    }
}
