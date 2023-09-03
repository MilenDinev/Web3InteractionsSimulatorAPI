namespace JaxWorld.Services.Main.Interfaces
{
    using Data.Entities.Transactions;
    using Models.Requests.BlockchainRequests.BlockModels;

    public interface IBlockService
    {
        Task<Block> CreateAsync(CreateBlockModel model, int creatorId);
        Task<Block> GetCurrentBlockAsync();
    }
}
