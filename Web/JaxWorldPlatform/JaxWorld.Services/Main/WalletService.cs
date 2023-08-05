namespace JaxWorld.Services.Main
{
    using AutoMapper;
    using Base;
    using Data;
    using Interfaces;
    using Data.Entities.Blockchain.Wallets;
    using Models.Requests.BlockchainRequests.WalletModels;
    using JaxWorld.Services.Constants;

    public class WalletService : BaseService<Wallet>, IWalletService
    {
        private readonly IMapper mapper;

        public WalletService(JaxWorldDbContext dbContext, IMapper mapper) : base(dbContext)
        {
            this.mapper = mapper;
        }

        public async Task<Wallet> CreateAsync(CreateWalletModel walletModel, int creatorId)
        {
            var wallet = mapper.Map<Wallet>(walletModel);

            var provider = walletModel.Provider == ProviderNames.MetamaskNum ||
                walletModel.Provider.ToLower() == ProviderNames.Metamask.ToLower() ?
                ProviderNames.Metamask : walletModel.Provider == ProviderNames.CoinBaseNum ||
                walletModel.Provider.ToLower() == ProviderNames.CoinBase.ToLower() ? 
                ProviderNames.CoinBase : ProviderNames.CoinBase;

            wallet.ProviderId = 1;

            await CreateEntityAsync(wallet, creatorId);
            return wallet;
        }

        public async Task EditAsync(Wallet wallet, EditWalletModel walletModel, int modifierId)
        {
            wallet.Owner.UserName = walletModel.Owner;

            await SaveModificationAsync(wallet, modifierId);
        }
        public async Task DeleteAsync(Wallet wallet, int modifierId)
        {
            await DeleteEntityAsync(wallet, modifierId);
        }
    }
}
