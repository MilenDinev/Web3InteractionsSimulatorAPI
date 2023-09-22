namespace JaxWorld.Services.Handlers.TxnDeployers
{
    using Constants;
    using Exceptions;
    using Interfaces;
    using Interfaces.ITxnManagers;
    using Data.Entities;
    using Models.Requests.BlockchainRequests.ProfileModels;
    using Models.Responses.BlockchainResponses.ProfileModels;

    public class ProfileTxnDeployer
    {
        private readonly IProfileTxnDeployerManager profileTxnDeployerManager;
        private readonly ITxnDeployerValidator txnDeployerValidator;

        public ProfileTxnDeployer(IProfileTxnDeployerManager profileTxnDeployerManager, ITxnDeployerValidator txnDeployerValidator)
        {
            this.profileTxnDeployerManager = profileTxnDeployerManager;
            this.txnDeployerValidator = txnDeployerValidator;
        }

        public async Task<CreatedProfileModel> DeployProfileTxnAsync(CreateProfileModel createProfileModel, User user)
        {
            var networkId = await this.profileTxnDeployerManager.GetProfileNetworkIdAsync(createProfileModel.ContractId);
            var gasUsed = GasUsedParams.Erc721aMintGas;

            var createTransactionModel = await this.profileTxnDeployerManager.GetCreateTxnModelAsync(TransactionStates.Pending, 
                TxnActions.Deploy,
                networkId, 
                user.Id,
                user.WalletId,
                gasUsed);

            _ = await this.txnDeployerValidator.ValidateContractOwner(user.Wallet, createProfileModel.ContractId);

            var contractAddress = await this.txnDeployerValidator.GetValidContractAddressAsync(createProfileModel.ContractId);

            var tokenGas = GasUsedParams.ProfileDeployGas * GasUsedParams.DeployMultiplierGas;

            var isValidWallet = await this.txnDeployerValidator.ValidateWalletAsync(user.Wallet, contractAddress, tokenGas);

            var transaction = await this.profileTxnDeployerManager.CreateTxnAsync(createTransactionModel, createProfileModel.ContractId);

            if (isValidWallet)
            {
               var createdProfileModel = await profileTxnDeployerManager.CreateProfileAsync(createProfileModel, user.Id);

                user.Wallet.Balance -= tokenGas;
                await this.profileTxnDeployerManager.UpdateTxnStateAsync(transaction, TransactionStates.Confirmed, user.Id);

               return createdProfileModel;
            }

            await this.profileTxnDeployerManager.UpdateTxnStateAsync(transaction, TransactionStates.Rejected, user.Id);
            throw new ResourceNotFoundException(string.Format(ErrorMessages.OperationExecutionRejected));

        }
    }
}
