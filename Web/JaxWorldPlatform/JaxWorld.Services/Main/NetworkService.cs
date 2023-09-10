namespace JaxWorld.Services.Main
{
    using AutoMapper;
    using Base;
    using Data;
    using Data.Entities;
    using Interfaces;
    using Models.Requests.BlockchainRequests.NetworkModels;
    using Models.Responses.BlockchainResponses.NetworkModels;
    using Constants;
    using Handlers.Exceptions;
    using Handlers.Interfaces;

    public class NetworkService : BaseService<Network>, INetworkService
    {
        private readonly IFinder finder;
        private readonly IMapper mapper;

        public NetworkService(JaxWorldDbContext dbContext,
            IFinder finder,
            IMapper mapper) : base(dbContext)
        {
            this.finder = finder;
            this.mapper = mapper;
        }

        public async Task<CreatedNetworkModel> CreateAsync(CreateNetworkModel networkModel, int creatorId)
        {
            await this.ValidateNetworkCreateInputAsync(networkModel.Name);

            var network = mapper.Map<Network>(networkModel);

            await CreateEntityAsync(network, creatorId);

            return mapper.Map<CreatedNetworkModel>(network);
        }

        public async Task<EditedNetworkModel> EditAsync(EditNetworkModel networkModel, int networkId, int modifierId)
        {
            var network = await this.GetNetworkAsync(networkId);

            network.Name = networkModel.Name ?? network.Name;
            network.RpcUrl = networkModel.RpcUrl ?? network.RpcUrl;
            network.ExplorerUrl = networkModel.ExplorerUrl ?? network.ExplorerUrl;
            network.ChainId = networkModel.ChainId.ToString() ?? network.ChainId;
            network.NormalizedTag = networkModel.Name?.ToUpper() ?? network.Name.ToUpper();
            network.Symbol = networkModel.Symbol ?? network.Symbol;

            await SaveModificationAsync(network, modifierId);

            return mapper.Map<EditedNetworkModel>(network);
        }

        public async Task<DeletedNetworkModel> DeleteAsync(int networkId, int modifierId)
        {
            var network = await this.GetNetworkAsync(networkId);

            await DeleteEntityAsync(network, modifierId);

            return mapper.Map<DeletedNetworkModel>(network);
        }

        public async Task<IEnumerable<NetworkListingModel>> GetAllActiveNetworksAsync()
        {
            var allNetworks = await this.finder.GetAllAsync<Network>();

            return mapper.Map<ICollection<NetworkListingModel>>(allNetworks.Where(x => !x.Deleted)).ToList();
        }

        public async Task<NetworkListingModel> GetByIdAsync(int networkId)
        {
            var network = await this.GetNetworkAsync(networkId);

            return mapper.Map<NetworkListingModel>(network);
        }

        private async Task<Network> GetNetworkAsync(int networkId)
        {
            var network = await this.finder.FindByIdOrDefaultAsync<Network>(networkId);

            if (network != null)
                return network;

            throw new ResourceNotFoundException(string.Format(
                ErrorMessages.EntityDoesNotExist, typeof(Network).Name));
        }

        private async Task ValidateNetworkCreateInputAsync(string networkName)
        {
            var network = await this.finder.AnyByStringAsync<Network>(networkName);

            if (network)
                throw new ResourceAlreadyExistsException(string.Format(
                    ErrorMessages.NamedEntityAlreadyExists,
                    typeof(Network).Name, networkName));
        }
    }
}

