namespace JaxWorld.Services.Main.Interfaces.Units
{
    using Data.Entities.Units;
    using Models.Requests.BlockchainRequests.UnitModels;

    public interface IErc721aUnitService
    {
        Task<Erc721aUnit> CreateAsync(CreateErc721aUnitModel model, int creatorId);
        Task EditAsync(Erc721aUnit unit, EditErc721aUnitModel model, int modifierId);
        Task DeleteAsync(Erc721aUnit unit, int modifierId);
    }
}
