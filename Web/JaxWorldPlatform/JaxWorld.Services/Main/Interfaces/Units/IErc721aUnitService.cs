namespace JaxWorld.Services.Main.Interfaces.Units
{
    using Data.Entities;
    using Models.Requests.BlockchainRequests.UnitModels;
    using Models.Responses.BlockchainResponses.ProfileUnitModels;
    using Models.Responses.BlockchainResponses.UnitModels;

    public interface IErc721aUnitService
    {
        Task<CreatedErc721aUnitModel> CreateAsync(CreateErc721aUnitModel unitModel, User user);
        Task<EditedErc721aUnitModel> EditAsync(EditErc721aUnitModel unitModel, int unitId, int modifierId);
        Task<DeletedErc721aUnitModel> DeleteAsync(int unitId, int modifierId);
        Task<Erc721aUnitListingModel> GetByIdAsync(int unitId);
        Task<int> GetUnitNetworkIdAsync(int profileId);
        Task<IEnumerable<Erc721aUnitListingModel>> GetAllActiveErc721aUnitsAsync();
    }
}
