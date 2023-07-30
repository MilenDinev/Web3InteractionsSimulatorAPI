namespace JaxWorld.Services.Main.Interfaces
{
    using Data.Entities.Blockchain.Wallets;
    using Models.Requests.BlockchainRequests.WalletModels;

    public interface IWalletService
    {
        Task<Wallet> CreateAsync(CreateWalletModel model, int creatorId);
        Task EditAsync(Wallet wallet, EditWalletModel model, int modifierId);
        Task DeleteAsync(Wallet wallet, int modifierId);
    }
}
