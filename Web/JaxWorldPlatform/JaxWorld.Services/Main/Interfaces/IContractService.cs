namespace JaxWorld.Services.Main.Interfaces
{
    using Data.Entities;
    using Models.Requests.BlockchainRequests.ContractModels;
    using Models.Responses.BlockchainResponses.ContractModels;

    public interface IContractService
    {
        Task<CreatedContractModel> CreateAsync(CreateContractModel contractModel, User user);
        Task<EditedContractModel> EditAsync(EditContractModel contractModel, int contractId, int modifierId);
        Task<DeletedContractModel> DeleteAsync(int contractId, int modifierId);
        Task<ContractListingModel> GetByIdAsync(int contractId);
        Task<IEnumerable<ContractListingModel>> GetAllActiveAsync();
    }
}
