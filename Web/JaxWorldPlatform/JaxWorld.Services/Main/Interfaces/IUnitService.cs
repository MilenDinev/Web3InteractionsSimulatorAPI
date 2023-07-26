namespace JaxWorld.Services.Main.Interfaces
{
    using Data.Entities.Blockchain.Base;
    using Models.Requests.BlockchainRequests.UnitModels;

    public interface IUnitService
    {
        Task<Unit> CreateAsync(CreateUnitModel model, int creatorId);
        Task EditAsync(Unit unit, EditUnitModel model, int modifierId);
        Task DeleteAsync(Unit unit, int modifierId);
    }
}
