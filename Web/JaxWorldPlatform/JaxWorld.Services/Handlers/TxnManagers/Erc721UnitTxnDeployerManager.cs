namespace JaxWorld.Services.Handlers.TxnManagers
{
    using Main.Interfaces;
    using Main.Interfaces.Units;
    using Interfaces.ITxnManagers;
    using Data.Entities;
    using Models.Requests.BlockchainRequests.UnitModels;
    using Models.Responses.BlockchainResponses.ProfileUnitModels;

    public class Erc721UnitTxnDeployerManager : TxnDeployerManager, IErc721UnitTxnDeployerManager
    {
        private readonly IErc721aUnitService erc721UnitService;

        public Erc721UnitTxnDeployerManager(IErc721aUnitService erc721UnitService,
            ITransactionService transactionService, IBlockService blockService) : base(transactionService, blockService)
        {
            this.erc721UnitService = erc721UnitService;
        }

        public async Task<int> GetUnitNetworkIdAsync(int profileId)
        {
            return await erc721UnitService.GetUnitNetworkIdAsync(profileId);
        }

        public async Task<CreatedErc721aUnitModel> CreateErc721UnitAsync(CreateErc721aUnitModel createErc721aUnitModel, User user)
        {
            return await this.erc721UnitService.CreateAsync(createErc721aUnitModel, user);
        }
    }
}
