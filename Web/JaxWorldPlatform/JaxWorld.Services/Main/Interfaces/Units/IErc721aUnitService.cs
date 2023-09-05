namespace JaxWorld.Services.Main.Interfaces.Units
{
    using Data.Entities.Units;
    using Models.Requests.BlockchainRequests.UnitModels;
    using Models.Responses.BlockchainResponses.ProfileUnitModels;

    public interface IErc721aUnitService
    {
        Task<CreatedErc721aUnitModel> CreateAsync(CreateErc721aUnitModel model, int creatorId);
        Task EditAsync(Erc721aUnit unit, EditErc721aUnitModel model, int modifierId);
        Task DeleteAsync(Erc721aUnit unit, int modifierId);
    }
}
