namespace JaxWorld.Services.Main
{
    using AutoMapper;
    using Base;
    using Interfaces;
    using Data;
    using Data.Entities.Blockchain.Base;
    using Models.Requests.BlockchainRequests.UnitModels;

    public class UnitService : BaseService<Unit>, IUnitService
    {
        private readonly IMapper mapper;

        public UnitService(JaxWorldDbContext dbContext, IMapper mapper) : base(dbContext)
        {
            this.mapper = mapper;
        }

        public async Task<Unit> CreateAsync(CreateUnitModel profileUnitModel, int creatorId)
        {
            var profileUnit = mapper.Map<Unit>(profileUnitModel);
            await CreateEntityAsync(profileUnit, creatorId);
            return profileUnit;
        }

        public async Task EditAsync(Unit profileUnit, EditUnitModel profileUnitModel, int modifierId)
        {
            profileUnit.Name = profileUnitModel.Name;

            await SaveModificationAsync(profileUnit, modifierId);
        }
        public async Task DeleteAsync(Unit profileUnit, int modifierId)
        {
            await DeleteEntityAsync(profileUnit, modifierId);
        }
    }
}
