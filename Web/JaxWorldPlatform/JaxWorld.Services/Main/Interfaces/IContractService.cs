namespace JaxWorld.Services.Main.Interfaces
{
    using Data.Entities.Contracts;
    using Models.Requests.BlockchainRequests.ContractModels;
    using Models.Responses.BlockchainResponses.ContractModels;

    public interface IContractService
    {
        Task<CreatedContractModel> CreateAsync(CreateContractModel model, int creatorWalletId, int creatorId);
        Task EditAsync(Contract contract, EditContractModel model, int modifierId);
        Task DeleteAsync(Contract contract, int modifierId);
    }
}
