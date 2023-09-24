namespace JaxWorld.Services.Handlers.TxnDeployers
{
    using Constants;
    using Exceptions;
    using Interfaces;
    using Interfaces.ITxnManagers;
    using Data.Entities;
    using Data.Entities.Base;
    using Data.Entities.Wallets;
    using Models.Requests.BlockchainRequests.UnitModels;
    using Models.Responses.BlockchainResponses.UnitModels;
    using Models.Responses.BlockchainResponses.ProfileUnitModels;

    public class Erc721UnitTxnDeployer
    {

        private readonly IErc721UnitTxnDeployerManager erc721UnitTxnDeployerManager;
        private readonly ITxnDeployerValidator txnDeployerValidator;

        public Erc721UnitTxnDeployer(IErc721UnitTxnDeployerManager erc721UnitTxnDeployerManager, ITxnDeployerValidator txnDeployerValidator)
        {
            this.erc721UnitTxnDeployerManager = erc721UnitTxnDeployerManager;
            this.txnDeployerValidator = txnDeployerValidator;
        }

        public async Task<CreatedErc721aUnitModel> MintErc721aUnitTxnAsync(CreateErc721aUnitModel createErc721aUnitModel, User user)
        {
            var networkId = await this.erc721UnitTxnDeployerManager.GetUnitNetworkIdAsync(createErc721aUnitModel.ProfileId);

            var gasUsed = GasUsedParams.Erc721aMintGas;

            var createTransactionModel = await this.erc721UnitTxnDeployerManager.GetCreateTxnModelAsync(TransactionStates.Pending, 
                TxnActions.Mint,
                networkId, 
                user.Id,
                user.WalletId,
                gasUsed);

            var tokenGas = gasUsed * GasUsedParams.MintMultiplierGas;

            var contract = await this.erc721UnitTxnDeployerManager.GetProfileContractAsync(user.Wallet, createErc721aUnitModel.ProfileId);

            var isValidWallet = await this.txnDeployerValidator.ValidateWalletAsync(user.Wallet, contract.Address, tokenGas);

            var transaction = await this.erc721UnitTxnDeployerManager.CreateTxnAsync(createTransactionModel, contract.Id);

            if (isValidWallet)
            {
                var createdErc721aUnitModel = await this.erc721UnitTxnDeployerManager.CreateErc721UnitAsync(createErc721aUnitModel, user);

                user.Wallet.Balance -= tokenGas;
                await this.erc721UnitTxnDeployerManager.UpdateTxnStateAsync(transaction, TransactionStates.Confirmed, transaction.CreatorId);

                return createdErc721aUnitModel;
            }

            await this.erc721UnitTxnDeployerManager.UpdateTxnStateAsync(transaction, TransactionStates.Rejected, user.Id);
            throw new ResourceNotFoundException(string.Format(ErrorMessages.OperationExecutionRejected));

        }

        public async Task<ClaimedUnitModel> ClaimUnitTxnAsync(ClaimUnitModel claimUnitModel, User user)
        {
            var contract = await this.erc721UnitTxnDeployerManager.GetProfileContractAsync(user.Wallet, claimUnitModel.ProfileId);
            var isContractApproved = await this.txnDeployerValidator.ValidateWalletApprovalAsync(user.Wallet.Address, contract.Address);

            if (!isContractApproved)
                throw new ResourceNotFoundException(string.Format(ErrorMessages.ContractNotApproved, typeof(Contract).Name, user.Wallet.Address));

            var isWalletHasBalance = await this.txnDeployerValidator.ValidateWalletBalanceAsync(user.Wallet.Balance, GasUsedParams.Erc721aMintGas);

            if (!isWalletHasBalance)
                throw new ResourceNotFoundException(string.Format(ErrorMessages.NotAvailableWalletBalance, typeof(Wallet).Name));

            var networkId = contract.Profile.Contract.NetworkId;

            var gasUsed = GasUsedParams.Erc721aMintGas;

            var createTransactionModel = await this.erc721UnitTxnDeployerManager.GetCreateTxnModelAsync(TransactionStates.Pending,
                TxnActions.Claim,
            networkId,
            user.Id,
            user.WalletId,
                gasUsed);

            var claimedUnitModel = await erc721UnitTxnDeployerManager.ClaimUnitAsync(claimUnitModel, user);

            var tokenGas = GasUsedParams.ProfileDeployGas * GasUsedParams.DeployMultiplierGas;
            user.Wallet.Balance -= tokenGas;
            var transaction = await this.erc721UnitTxnDeployerManager.CreateTxnAsync(createTransactionModel, contract.Id);

            await this.erc721UnitTxnDeployerManager.UpdateTxnStateAsync(transaction, TransactionStates.Confirmed, user.Id);

            return claimedUnitModel;
        }

        public async Task<TransferedUnitModel> TransferUnitTxnAsync(TransferUnitModel transferUnitModel, User user)
        {

            var isWalletHasBalance = await this.txnDeployerValidator.ValidateWalletBalanceAsync(user.Wallet.Balance, GasUsedParams.TransferUnitGas);

            if (!isWalletHasBalance)
                throw new ResourceNotFoundException(string.Format(ErrorMessages.NotAvailableWalletBalance, typeof(Wallet).Name));


            var profile = await this.erc721UnitTxnDeployerManager.GetUnitProfileAsync(transferUnitModel.UnitId);

            var networkId = profile.Contract.NetworkId;

            var gasUsed = GasUsedParams.TransferUnitGas;

            var createTransactionModel = await this.erc721UnitTxnDeployerManager.GetCreateTxnModelAsync(TransactionStates.Pending,
                TxnActions.Claim,
            networkId,
            user.Id,
            user.WalletId,
                gasUsed);

            var transferedUnitModel = await erc721UnitTxnDeployerManager.TransferUnitAsync(transferUnitModel, user);

            var tokenGas = GasUsedParams.TransferUnitGas * GasUsedParams.TransferMultiplierGas;
            user.Wallet.Balance -= tokenGas;

            var contractId = profile.ContractId;

            var transaction = await this.erc721UnitTxnDeployerManager.CreateTxnAsync(createTransactionModel, contractId);

            await this.erc721UnitTxnDeployerManager.UpdateTxnStateAsync(transaction, TransactionStates.Confirmed, user.Id);

            return transferedUnitModel;
        }

        public async Task<BoughtUnitModel> BuyUnitTxnAsync(BuyUnitModel buyUnitModel, User user)
        {

            var isUnitForSale = await this.txnDeployerValidator.ValidateUnitForSaleAsync(buyUnitModel.UnitId);
            if (!isUnitForSale)
                throw new ResourceNotFoundException(string.Format(ErrorMessages.UnitNotForSale, typeof(Unit).Name, buyUnitModel.UnitId));

            var profile = await this.erc721UnitTxnDeployerManager.GetUnitProfileAsync(buyUnitModel.UnitId);

            var isContractApproved = await this.txnDeployerValidator.ValidateWalletApprovalAsync(user.Wallet.Address, profile.Contract.Address);

            if (!isContractApproved)
                throw new ResourceNotFoundException(string.Format(ErrorMessages.ContractNotApproved, typeof(Contract).Name, user.Wallet.Address));

            var isWalletHasBalance = await this.txnDeployerValidator.ValidateWalletBalanceAsync(user.Wallet.Balance, buyUnitModel.Price);

            if (!isWalletHasBalance)
                throw new ResourceNotFoundException(string.Format(ErrorMessages.NotAvailableWalletBalance, typeof(Wallet).Name));

            var networkId = profile.Contract.NetworkId;

            var gasUsed = GasUsedParams.UnitBuyGas;

            var createTransactionModel = await this.erc721UnitTxnDeployerManager.GetCreateTxnModelAsync(TransactionStates.Pending,
                TxnActions.Claim,
                networkId,
                user.Id,
                user.WalletId,
                gasUsed);

            var boughtUnitModel = await erc721UnitTxnDeployerManager.BuyUnitAsync(buyUnitModel, user);

            var tokenGas = buyUnitModel.Price;
            user.Wallet.Balance -= tokenGas;

            var contractId = profile.ContractId;

            var transaction = await this.erc721UnitTxnDeployerManager.CreateTxnAsync(createTransactionModel, contractId);

            await this.erc721UnitTxnDeployerManager.UpdateTxnStateAsync(transaction, TransactionStates.Confirmed, user.Id);

            return boughtUnitModel;
        }

        public async Task<ListedSellUnitModel> ListSellUnitTxnAsync(ListSellUnitModel listSellUnitModel, User user)
        {

            var isUnitForSale = await this.txnDeployerValidator.ValidateUnitForSaleAsync(listSellUnitModel.UnitId);
            if (isUnitForSale)
                throw new ResourceNotFoundException(string.Format(ErrorMessages.UnitAlreadyListedForSale, typeof(Unit).Name, listSellUnitModel.UnitId));

            var profile = await this.erc721UnitTxnDeployerManager.GetUnitProfileAsync(listSellUnitModel.UnitId);

            var isUnitOwner = await this.txnDeployerValidator.ValidateUnitOwnerAsync(user.Wallet, listSellUnitModel.UnitId);

            if (!isUnitOwner)
                throw new ResourceNotFoundException(string.Format(ErrorMessages.WalletNotUnitOwner, typeof(Wallet).Name, listSellUnitModel.UnitId));

            var gasUsed = GasUsedParams.ListUnitSaleGas;

            var isWalletHasBalance = await this.txnDeployerValidator.ValidateWalletBalanceAsync(user.Wallet.Balance, gasUsed);

            if (!isWalletHasBalance)
                throw new ResourceNotFoundException(string.Format(ErrorMessages.NotAvailableWalletBalance, typeof(Wallet).Name));

            var networkId = profile.Contract.NetworkId;

            var createTransactionModel = await this.erc721UnitTxnDeployerManager.GetCreateTxnModelAsync(TransactionStates.Pending,
                TxnActions.Claim,
                networkId,
            user.Id,
            user.WalletId,
            gasUsed);

            var listedForSellUnitModel = await erc721UnitTxnDeployerManager.ListUnitSell(listSellUnitModel, user);

            var tokenGas = GasUsedParams.ListUnitSaleGas * GasUsedParams.SaleMultiplierGas;
            user.Wallet.Balance -= tokenGas;

            var contractId = profile.ContractId;

            var transaction = await this.erc721UnitTxnDeployerManager.CreateTxnAsync(createTransactionModel, contractId);

            await this.erc721UnitTxnDeployerManager.UpdateTxnStateAsync(transaction, TransactionStates.Confirmed, user.Id);

            return listedForSellUnitModel;
        }
    }
}
