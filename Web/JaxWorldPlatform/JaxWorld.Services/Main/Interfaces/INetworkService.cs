namespace JaxWorld.Services.Main.Interfaces
{
    using Data.Entities;
    using JaxWorld.Models.Responses.BlockchainResponses.NetworkModels;
    using Models.Requests.BlockchainRequests.NetworkModels;

    public interface INetworkService
    {
        Task<CreatedNetworkModel> CreateAsync(CreateNetworkModel model, int creatorId);
        Task<EditedNetworkModel> EditAsync(EditNetworkModel networkModel, int networkId, int modifierId);
        Task<DeletedNetworkModel> DeleteAsync(int networkId, int modifierId);
        Task<NetworkListingModel> GetByIdAsync(int networkId);
        Task<IEnumerable<NetworkListingModel>> GetGetAllActiveAsync();
    }
}
