namespace JaxWorld.Services.Main
{
    using AutoMapper;
    using Base;
    using Data;
    using Interfaces;
    using Data.Entities.Blockchain;
    using Models.Requests.BlockchainRequests.StandardModels;

    public class StandardService : BaseService<Standard>, IStandardService
    {
        private readonly IMapper mapper;

        public StandardService(JaxWorldDbContext dbContext, IMapper mapper) : base(dbContext)
        {
            this.mapper = mapper;
        }

        public async Task<Standard> CreateAsync(CreateStandardModel standardModel, int creatorId)
        {
            var standard = mapper.Map<Standard>(standardModel);
            await CreateEntityAsync(standard, creatorId);
            return standard;
        }

        public async Task EditAsync(Standard standard, EditStandardModel standardModel, int modifierId)
        {
            standard.Name = standardModel.Name;

            await SaveModificationAsync(standard, modifierId);
        }
        public async Task DeleteAsync(Standard standard, int modifierId)
        {
            await DeleteEntityAsync(standard, modifierId);
        }
    }
}
