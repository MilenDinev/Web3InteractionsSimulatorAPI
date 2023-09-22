namespace JaxWorld.Services.Handlers.TxnManagers
{
    using System.Threading.Tasks;
    using Main.Interfaces;
    using Interfaces.ITxnManagers;
    using Data.Entities;
    using Models.Requests.BlockchainRequests.ContractModels;
    using Models.Responses.BlockchainResponses.ContractModels;

    public class ContractTxnDeployerManager : TxnDeployerManager, IContractTxnDeployerManager
    {
        private readonly IContractService contractService;

        public ContractTxnDeployerManager(IContractService contractService,
            ITransactionService transactionService, IBlockService blockService) : base(transactionService, blockService)
        {
            this.contractService = contractService;
        }

        public async Task<CreatedContractModel> CreateContractAsync(CreateContractModel createContractModel, User user)
        {
            return await contractService.CreateAsync(createContractModel, user);
        }
    }
}
