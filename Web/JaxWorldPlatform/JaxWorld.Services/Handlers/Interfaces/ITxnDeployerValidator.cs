namespace JaxWorld.Services.Handlers.Interfaces
{
    using Data.Entities.Wallets;

    public interface ITxnDeployerValidator
    {
        Task<bool> ValidateWalletAsync(Wallet wallet, string contractAddress, decimal cost);
        Task<string> GetValidContractAddressAsync(int contractId);
        Task<bool> ValidateContractOwner(Wallet wallet, int contractId);
    }
}
