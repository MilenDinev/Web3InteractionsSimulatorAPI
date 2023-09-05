namespace JaxWorld.Services.Main.Units
{
    using AutoMapper;
    using Base;
    using Interfaces.Units;
    using Data;
    using Data.Entities.Units;
    using Models.Requests.BlockchainRequests.UnitModels;

    public class Erc721aUnitService : BaseService<Erc721aUnit>, IErc721aUnitService
    {
        private readonly IMapper mapper;

        public Erc721aUnitService(JaxWorldDbContext dbContext, IMapper mapper) : base(dbContext)
        {
            this.mapper = mapper;
        }

        public async Task<Erc721aUnit> CreateAsync(CreateErc721aUnitModel profileUnitModel, int creatorId)
        {
            var profileUnit = mapper.Map<Erc721aUnit>(profileUnitModel);

            await CreateEntityAsync(profileUnit, creatorId);

            return profileUnit;
        }

        public async Task EditAsync(Erc721aUnit profileUnit, EditErc721aUnitModel profileUnitModel, int modifierId)
        {
            profileUnit.Name = profileUnitModel.Name;

            await SaveModificationAsync(profileUnit, modifierId);
        }

        public async Task DeleteAsync(Erc721aUnit profileUnit, int modifierId)
        {
            await DeleteEntityAsync(profileUnit, modifierId);
        }
    }
}
