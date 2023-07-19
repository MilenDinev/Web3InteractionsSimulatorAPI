namespace JaxWorld.Services.Main
{
    using AutoMapper;
    using Base;
    using Data;
    using Data.Entities.Blockchain;
    using Models.Requests.BlockchainRequests.ChainModels;


    internal class NetworkService : BaseService<Network>
    {
        private readonly IMapper mapper;

        public NetworkService(JaxWorldDbContext dbContext, IMapper mapper) : base(dbContext)
        {
            this.mapper = mapper;
        }

        public async Task<Network> CreateAsync(CreateNetworkModel networkModel, int creatorId)
        {
            var network = mapper.Map<Network>(networkModel);
            await CreateEntityAsync(network, creatorId);
            return network;
        }

        public async Task EditAsync(Network network, EditNetworkModel networkModel, int modifierId)
        {
            network.RpcUrl = networkModel.RpcUrl;
            network.ExplorerUrl = networkModel.ExplorerUrl;
            network.ChainId = networkModel.ChainId.ToUpper(); ;
            network.Name = networkModel.Name;
            network.Symbol = networkModel.Symbol;

            await SaveModificationAsync(network, modifierId);
        }
        public async Task DeleteAsync(Network network, int modifierId)
        {
            await DeleteEntityAsync(network, modifierId);
        }
    }
}

