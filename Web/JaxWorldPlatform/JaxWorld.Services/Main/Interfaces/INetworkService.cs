namespace JaxWorld.Services.Main.Interfaces
{
    using Models.Requests.BlockchainRequests.NetworkModels;
    using Models.Responses.BlockchainResponses.NetworkModels;

    public interface INetworkService
    {
        Task<CreatedNetworkModel> CreateAsync(CreateNetworkModel model, int creatorId);
        Task<EditedNetworkModel> EditAsync(EditNetworkModel networkModel, int networkId, int modifierId);
        Task<DeletedNetworkModel> DeleteAsync(int networkId, int modifierId);
        Task<NetworkListingModel> GetByIdAsync(int networkId);
        Task<IEnumerable<NetworkListingModel>> GetAllActiveNetworksAsync();
    }
}
