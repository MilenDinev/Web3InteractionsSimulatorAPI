namespace JaxWorld.Services.Handlers.Interfaces
{
    using Data.Entities.Wallets;

    public interface ITxnDeployerValidator
    {
        Task<bool> ValidateWalletAsync(Wallet wallet, string contractAddress, decimal cost);
        Task<string> GetValidContractAddressAsync(int contractId);
        Task<bool> ValidateContractOwnerAsync(Wallet wallet, int contractId);
        Task<bool> ValidateWalletApprovalAsync(string walletAddress, string contractAddress);
        Task<bool> ValidateWalletBalanceAsync(decimal walletBalance, decimal cost);
        Task<bool> ValidateUnitForSaleAsync(int unitId);
        Task<bool> ValidateUnitOwnerAsync(Wallet wallet, int unitId);
    }
}
