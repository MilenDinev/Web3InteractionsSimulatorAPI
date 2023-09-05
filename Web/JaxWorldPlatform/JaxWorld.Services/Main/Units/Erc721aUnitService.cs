namespace JaxWorld.Services.Main.Units
{
    using AutoMapper;
    using Base;
    using Interfaces.Units;
    using Data;
    using Data.Entities.Units;
    using Models.Requests.BlockchainRequests.UnitModels;
    using Models.Responses.BlockchainResponses.ProfileUnitModels;

    public class Erc721aUnitService : BaseService<Erc721aUnit>, IErc721aUnitService
    {
        private readonly IMapper mapper;

        public Erc721aUnitService(JaxWorldDbContext dbContext, IMapper mapper) : base(dbContext)
        {
            this.mapper = mapper;
        }

        public async Task<CreatedErc721aUnitModel> CreateAsync(CreateErc721aUnitModel unitModel, int creatorId)
        {
            var unit = mapper.Map<Erc721aUnit>(unitModel);

            await CreateEntityAsync(unit, creatorId);

            var createdUnit = mapper.Map<CreatedErc721aUnitModel>(unit);

            return createdUnit;
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
