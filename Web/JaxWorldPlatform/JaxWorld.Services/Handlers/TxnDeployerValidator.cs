namespace JaxWorld.Services.Handlers
{
    using Constants;
    using Exceptions;
    using Interfaces;
    using Data.Entities.Wallets;
    using Data.Entities.Contracts;

    public class TxnDeployerValidator : ITxnDeployerValidator
    {
        private readonly IFinder finder;

        public TxnDeployerValidator(IFinder finder)
        {
            this.finder = finder;
        }

        public async Task<bool> ValidateWalletAsync(Wallet wallet, string contractAddress, decimal cost)
        {
            var isValidWallet = await ValidateWalletApprovalAsync(wallet.Address, contractAddress)
                && await ValidateWalletBalanceAsync(wallet.Balance, cost);

            return isValidWallet;
        }

        public async Task<string> GetValidContractAddressAsync(int contractId)
        {
            var contract = await this.finder.FindByIdOrDefaultAsync<Contract>(contractId)
            ?? throw new ResourceNotFoundException(string.Format(ErrorMessages.EntityDoesNotExist,
            typeof(Contract).Name));
            return contract.Address;
        }

        public async Task<bool> ValidateContractOwner(Wallet wallet, int contractId)
        {
            return await Task.Run(() => wallet.CreatedContracts.Any(c => c.Id == contractId));
        }

        private async Task<bool> ValidateWalletApprovalAsync(string walletAddress, string contractAddress)
        {
            var contract = await this.finder.FindByStringOrDefaultAsync<Contract>(contractAddress);
            var isValidWallet = false; 

            if (contract != null)
            {
                isValidWallet = contract.ApprovedBy.Any(x => x.Address == walletAddress);
            }

            return isValidWallet;
        }

        private static async Task<bool> ValidateWalletBalanceAsync(decimal walletBalance, decimal cost)
        {
            var isValidWallet = await Task.Run(() => walletBalance - cost >= 0.00000000M);

            return isValidWallet;
        }
    }
}
