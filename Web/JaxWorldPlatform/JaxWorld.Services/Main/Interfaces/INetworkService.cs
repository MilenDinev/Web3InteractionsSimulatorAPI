namespace JaxWorld.Services.Main.Interfaces
{
    using Data.Entities.Blockchain;
    using Models.Requests.BlockchainRequests.NetworkModels;

    public interface INetworkService
    {
        Task<Network> CreateAsync(CreateNetworkModel model, int creatorId);
        Task EditAsync(Network network, EditNetworkModel model, int modifierId);
        Task DeleteAsync(Network network, int modifierId);
    }
}
