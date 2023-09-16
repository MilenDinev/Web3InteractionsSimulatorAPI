namespace JaxWorld.Services.Handlers.Interfaces
{
    using Data.Entities;
    using Models.Requests.BlockchainRequests.ContractModels;
    using Models.Responses.BlockchainResponses.ContractModels;

    public interface IContractTransactionDeployer
    {
        Task<CreatedContractModel> DeployContractTxnAsync(CreateContractModel createContractModel, User user);
    }
}
