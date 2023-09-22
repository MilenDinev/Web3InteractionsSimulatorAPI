namespace JaxWorld.Services.Handlers.Interfaces.ITxnManagers
{
    using Data.Entities;
    using Models.Requests.BlockchainRequests.ContractModels;
    using Models.Responses.BlockchainResponses.ContractModels;

    public interface IContractTxnDeployerManager : ITxnDeployerManager
    {
        Task<CreatedContractModel> CreateContractAsync(CreateContractModel createContractModel, User user);
    }
}
