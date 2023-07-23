namespace JaxWorld.Services.Main
{
    using AutoMapper;
    using Base;
    using Data;
    using Data.Entities.Blockchain.Properties;
    using Models.Requests.BlockchainRequests.PropertiesModels;

    internal class UtilityService : BaseService<Utility>
    {
        private readonly IMapper mapper;

        public UtilityService(JaxWorldDbContext dbContext, IMapper mapper) : base(dbContext)
        {
            this.mapper = mapper;
        }

        public async Task<Utility> CreateAsync(CreateUtilityModel utilityModel, int creatorId)
        {
            var utility = mapper.Map<Utility>(utilityModel);
            await CreateEntityAsync(utility, creatorId);
            return utility;
        }

        public async Task EditAsync(Utility utility, EditUtilityModel utilityModel, int modifierId)
        {
            utility.Type = utilityModel.Name;

            await SaveModificationAsync(utility, modifierId);
        }
        public async Task DeleteAsync(Utility utility, int modifierId)
        {
            await DeleteEntityAsync(utility, modifierId);
        }
    }
}
