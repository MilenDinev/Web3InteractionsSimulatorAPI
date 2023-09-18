namespace JaxWorld.Services.Handlers.Interfaces
{
    using Data.Entities;
    using Models.Requests.BlockchainRequests.ContractModels;
    using Models.Responses.BlockchainResponses.ContractModels;

    public interface IContractTxnDeployer
    {
        Task<CreatedContractModel> DeployContractTxnAsync(CreateContractModel createContractModel, User user);
    }
}
