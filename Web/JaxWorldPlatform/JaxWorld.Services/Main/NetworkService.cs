namespace JaxWorld.Services.Main
{
    using AutoMapper;
    using Base;
    using Interfaces;
    using Data;
    using Data.Entities;
    using Models.Requests.BlockchainRequests.NetworkModels;
    using Models.Responses.BlockchainResponses.NetworkModels;
    using Handlers.Interfaces;

    public class NetworkService : BaseService<Network>, INetworkService
    {
        private readonly IFinder finder;
        private readonly IValidator validator;
        private readonly IMapper mapper;

        public NetworkService(JaxWorldDbContext dbContext,
            IFinder finder,
            IValidator validator,
            IMapper mapper) : base(dbContext)
        {
            this.finder = finder;
            this.validator = validator;
            this.mapper = mapper;
        }

        public async Task<CreatedNetworkModel> CreateAsync(CreateNetworkModel networkModel, int creatorId)
        {
            var network = await this.finder.FindByStringOrDefaultAsync<Network>(networkModel.Name);
            await this.validator.ValidateUniqueEntityAsync(network);

             network = mapper.Map<Network>(networkModel);

            await CreateEntityAsync(network, creatorId);

            return mapper.Map<CreatedNetworkModel>(network);
        }

        public async Task<EditedNetworkModel> EditAsync(EditNetworkModel networkModel, int networkId, int modifierId)
        {

            var network = await this.finder.FindByIdOrDefaultAsync<Network>(networkId);

            await this.validator.ValidateTargetEntityAvailabilityAsync(network);

            network.Name = networkModel.Name;
            network.RpcUrl = networkModel.RpcUrl;
            network.ExplorerUrl = networkModel.ExplorerUrl;
            network.ChainId = networkModel.ChainId.ToString();
            network.NormalizedTag = networkModel.Name.ToUpper();
            network.Symbol = networkModel.Symbol;

            await SaveModificationAsync(network, modifierId);

            return mapper.Map<EditedNetworkModel>(network);
        }

        public async Task<DeletedNetworkModel> DeleteAsync(int networkId, int modifierId)
        {

            var network = await this.finder.FindByIdOrDefaultAsync<Network>(networkId);

            await this.validator.ValidateTargetEntityAvailabilityAsync(network);

            await DeleteEntityAsync(network, modifierId);

            return mapper.Map<DeletedNetworkModel>(network);
        }


        public async Task<NetworkListingModel> GetByIdAsync(int networkId)
        {
            var network = await this.finder.FindByIdOrDefaultAsync<Network>(networkId);
            await this.validator.ValidateTargetEntityAvailabilityAsync(network);

            return mapper.Map<NetworkListingModel>(network);
        }

        public async Task<IEnumerable<NetworkListingModel>> GetGetAllActiveAsync()
        {
            var allNetworks = await this.finder.GetAllActiveAsync<Network>();

            return mapper.Map<ICollection<NetworkListingModel>>(allNetworks);
        }
    }
}

