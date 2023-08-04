namespace JaxWorld.Services.Main.Interfaces
{
    using Data.Entities.Blockchain.Units;
    using Models.Requests.BlockchainRequests.UnitModels;

    public interface IErc721aUnitService
    {
        Task<Erc721aUnit> CreateAsync(CreateErc721aUnitModel model, int creatorId);
        Task EditAsync(Erc721aUnit unit, EditErc721aUnitModel model, int modifierId);
        Task DeleteAsync(Erc721aUnit unit, int modifierId);
    }
}
