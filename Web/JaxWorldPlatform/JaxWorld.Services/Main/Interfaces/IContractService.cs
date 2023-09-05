namespace JaxWorld.Services.Main.Interfaces
{
    using Data.Entities.Contracts;
    using Models.Requests.BlockchainRequests.ContractModels;

    public interface IContractService
    {
        Task<Contract> CreateAsync(CreateContractModel model, int creatorId);
        Task EditAsync(Contract contract, EditContractModel model, int modifierId);
        Task DeleteAsync(Contract contract, int modifierId);
    }
}
