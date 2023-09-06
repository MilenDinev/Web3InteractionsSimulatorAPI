namespace JaxWorld.Services.Main.Units
{
    using AutoMapper;
    using Base;
    using Interfaces.Units;
    using Handlers.Interfaces;
    using Data;
    using Data.Entities;
    using Data.Entities.Units;
    using Models.Requests.BlockchainRequests.UnitModels;
    using Models.Responses.BlockchainResponses.UnitModels;
    using Models.Responses.BlockchainResponses.ProfileUnitModels;
    using Profile = Data.Entities.Profiles.Profile;

    public class Erc721aUnitService : BaseService<Erc721aUnit>, IErc721aUnitService
    {
        private readonly IFinder finder;
        private readonly IValidator validator;
        private readonly IMapper mapper;

        public Erc721aUnitService(JaxWorldDbContext dbContext,
            IFinder finder,
            IValidator validator,
            IMapper mapper) : base(dbContext)
        {
            this.finder = finder;
            this.validator = validator;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<Erc721aUnitListingModel>> GetAllActiveAsync()
        {
            var allUnits = await finder.GetAllActiveAsync<Erc721aUnit>();

            return mapper.Map<ICollection<Erc721aUnitListingModel>>(allUnits).ToList();
        }

        public async Task<Erc721aUnitListingModel> GetByIdAsync(int unitId)
        {
            var unit = await finder.FindByIdOrDefaultAsync<Erc721aUnit>(unitId);
            await validator.ValidateTargetEntityAvailabilityAsync(unit);

            return mapper.Map<Erc721aUnitListingModel>(unit);
        }


        public async Task<CreatedErc721aUnitModel> CreateAsync(CreateErc721aUnitModel unitModel, User user)
        {
            var unit = await finder.FindByStringOrDefaultAsync<Erc721aUnit>(unitModel.Name);
            await validator.ValidateUniqueEntityAsync(unit);

            var profile = await this.finder.FindByIdOrDefaultAsync<Profile>(unitModel.ProfileId);
            await this.validator.ValidateTargetEntityAvailabilityAsync(profile);

            var activeWallet = user.Wallets.FirstOrDefault();

            await this.validator.ValidateContractOwnershipAsync(activeWallet, profile.ContractId);

            unit = mapper.Map<Erc721aUnit>(unitModel);

            await CreateEntityAsync(unit, user.Id);

            var createdUnit = mapper.Map<CreatedErc721aUnitModel>(unit);

            return createdUnit;
        }

        public async Task<EditedErc721aUnitModel> EditAsync(EditErc721aUnitModel unitModel, int unitId, int modifierId)
        {
            var unit = await finder.FindByIdOrDefaultAsync<Erc721aUnit>(unitId);

            await validator.ValidateTargetEntityAvailabilityAsync(unit);

            unit.Name = unitModel.Name;

            await SaveModificationAsync(unit, modifierId);

            return mapper.Map<EditedErc721aUnitModel>(unit);
        }

        public async Task<DeletedErc721aUnitModel> DeleteAsync(int unitId, int modifierId)
        {
            var unit = await finder.FindByIdOrDefaultAsync<Erc721aUnit>(unitId);

            await validator.ValidateTargetEntityAvailabilityAsync(unit);

            await DeleteEntityAsync(unit, modifierId);

            return mapper.Map<DeletedErc721aUnitModel>(unit);
        }
    }
}
