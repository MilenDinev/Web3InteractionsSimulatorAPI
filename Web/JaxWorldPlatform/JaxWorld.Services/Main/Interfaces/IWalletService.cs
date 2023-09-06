﻿namespace JaxWorld.Services.Main.Interfaces
{
    using Models.Requests.BlockchainRequests.WalletModels;
    using Models.Responses.BlockchainResponses.WalletModels;

    public interface IWalletService
    {
        Task<CreatedWalletModel> CreateAsync(CreateWalletModel model, int creatorId);
        Task<EditedWalletModel> EditAsync(EditWalletModel model, int walletId, int modifierId);
        Task<DeletedWalletModel> DeleteAsync(int walletId, int modifierId);
        Task<WalletListingModel> GetById(int walletId);
        Task<IEnumerable<WalletListingModel>> GetAllActiveAsync();
    }
}
