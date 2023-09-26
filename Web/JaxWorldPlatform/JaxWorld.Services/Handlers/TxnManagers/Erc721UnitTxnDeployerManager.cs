namespace JaxWorld.Services.Handlers.TxnManagers
{
    using Main.Interfaces;
    using Main.Interfaces.Units;
    using Interfaces.ITxnManagers;
    using Data.Entities;
    using Models.Requests.BlockchainRequests.UnitModels;
    using Models.Responses.BlockchainResponses.UnitModels;
    using Models.Responses.BlockchainResponses.ProfileUnitModels;

    public class Erc721UnitTxnDeployerManager : TxnDeployerManager, IErc721UnitTxnDeployerManager
    {
        private readonly IErc721aUnitService erc721UnitService;

        public Erc721UnitTxnDeployerManager(IErc721aUnitService erc721UnitService,
            ITransactionService transactionService, IBlockService blockService) : base(transactionService, blockService)
        {
            this.erc721UnitService = erc721UnitService;
        }

        public async Task<CreatedErc721aUnitModel> CreateErc721UnitAsync(CreateErc721aUnitModel createErc721aUnitModel, User user)
        {
            return await this.erc721UnitService.CreateAsync(createErc721aUnitModel, user);
        }

        public async Task<ClaimedUnitModel> ClaimUnitAsync(ClaimUnitModel claimUnitModel, User user)
        {
            return await this.erc721UnitService.ClaimAsync(claimUnitModel, user);
        }

        public async Task<Profile> GetUnitProfileAsync(int unitId)
        {
            return await this.erc721UnitService.GetUnitProfileIdAsync(unitId);
        }

        public async Task<int> GetUnitNetworkIdAsync(int unitId)
        {
            return await erc721UnitService.GetUnitNetworkIdAsync(unitId);
        }


        public async Task<TransferedUnitModel> TransferUnitAsync(TransferUnitModel transferUnitModel, User user)
        {
            return await this.erc721UnitService.TransferAsync(transferUnitModel, user);
        }

        public async Task<BoughtUnitModel> BuyUnitAsync(BuyUnitModel buyUnitModel, User user)
        {
            return await this.erc721UnitService.BuyAsync(buyUnitModel, user);
        }

        public async Task<ListedSellUnitModel> ListUnitSell(ListSellUnitModel listSellUnitModel, User user)
        {
            return await this.erc721UnitService.ListForSellAsync(listSellUnitModel, user);
        }
    }
}
