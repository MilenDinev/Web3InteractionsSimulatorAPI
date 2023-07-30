namespace JaxWorld.Services.Main.Interfaces
{
    using Data.Entities.Blockchain;
    using Models.Requests.BlockchainRequests.StandardModels;

    public interface IStandardService
    {
        Task<Standard> CreateAsync(CreateStandardModel model, int creatorId);
        Task EditAsync(Standard standard, EditStandardModel model, int modifierId);
        Task DeleteAsync(Standard standard, int modifierId);
    }
}
