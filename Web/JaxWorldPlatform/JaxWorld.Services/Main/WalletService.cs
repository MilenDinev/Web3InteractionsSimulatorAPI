namespace JaxWorld.Services.Main
{
    using AutoMapper;
    using Base;
    using Data;
    using Data.Entities.Blockchain.Wallets;
    using Models.Requests.BlockchainRequests.WalletModels;

    internal class WalletService : BaseService<Wallet>
    {
        private readonly IMapper mapper;

        public WalletService(JaxWorldDbContext dbContext, IMapper mapper) : base(dbContext)
        {
            this.mapper = mapper;
        }

        public async Task<Wallet> CreateAsync(CreateWalletModel walletModel, int creatorId)
        {
            var wallet = mapper.Map<Wallet>(walletModel);
            await CreateEntityAsync(wallet, creatorId);
            return wallet;
        }

        public async Task EditAsync(Wallet wallet, EditWalletModel walletModel, int modifierId)
        {
            wallet.Name = walletModel.Name;

            await SaveModificationAsync(wallet, modifierId);
        }
        public async Task DeleteAsync(Wallet wallet, int modifierId)
        {
            await DeleteEntityAsync(wallet, modifierId);
        }
    }
}
