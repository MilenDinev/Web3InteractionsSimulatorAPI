namespace JaxWorld.Services.Main.Properties
{
    using AutoMapper;
    using Base;
    using Data;
    using Interfaces.Properties;
    using Data.Entities.Blockchain.Properties;
    using Models.Requests.BlockchainRequests.PropertiesModels;

    public class UtilityService : BaseService<Utility>, IUtilityService
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
            utility.Value = utilityModel.Value;

            await SaveModificationAsync(utility, modifierId);
        }

        public async Task DeleteAsync(Utility utility, int modifierId)
        {
            await DeleteEntityAsync(utility, modifierId);
        }
    }
}
