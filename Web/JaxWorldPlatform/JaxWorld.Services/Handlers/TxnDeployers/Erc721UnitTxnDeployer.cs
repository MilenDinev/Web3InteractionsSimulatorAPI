namespace JaxWorld.Services.Handlers.TxnDeployers
{
    using Constants;
    using Main.Interfaces;
    using Main.Interfaces.Units;
    using Data.Entities;
    using Models.Requests.BlockchainRequests.UnitModels;

    public class Erc721UnitTxnDeployer : TransactionDeployer
    {
        protected readonly IErc721aUnitService erc721aUnitService;

        public Erc721UnitTxnDeployer(
            IErc721aUnitService erc721aUnitService,
            IBlockService blockService,
            ITransactionService transactionService
            ) : base(blockService, transactionService)
        {
            this.erc721aUnitService = erc721aUnitService;
        }

        public async Task MintErc721aUnitTxnAsync(CreateErc721aUnitModel createErc721aUnitModel, User user)
        {
            var createdErc721aUnitModel = await erc721aUnitService.CreateAsync(createErc721aUnitModel, user);

            var createTransactionModel = await GetCreateTxnModelAsync(TransactionStates.Pending, 
                TxnActions.Mint,
                createdErc721aUnitModel.NetworkId, user.Id, 
                createdErc721aUnitModel.CreatorWalletId, 
                GasUsedParams.Erc721aMintGas);

            var transaction = await transactionService.CreateAsync(createTransactionModel, createdErc721aUnitModel.Id);

            await transactionService.UpdateStateAsync(transaction, TransactionStates.Confirmed, transaction.CreatorId);

        }

    }
}
