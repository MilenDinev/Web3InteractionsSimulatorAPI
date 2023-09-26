namespace JaxWorld.Services.Main.Units
{
    using AutoMapper;
    using Base;
    using Data;
    using Data.Entities;
    using Data.Entities.Units;
    using Data.Entities.Wallets;
    using Profile = Data.Entities.Profile;
    using Handlers.Interfaces;
    using Interfaces.Units;
    using Services.Constants;
    using Services.Handlers.Exceptions;
    using Models.Requests.BlockchainRequests.UnitModels;
    using Models.Responses.BlockchainResponses.ProfileUnitModels;
    using Models.Responses.BlockchainResponses.UnitModels;

    public class Erc721aUnitService : BaseService<Erc721aUnit>, IErc721aUnitService
    {
        private readonly IFinder finder;
        private readonly IMapper mapper;

        public Erc721aUnitService(JaxWorldDbContext dbContext,
            IFinder finder,
            IMapper mapper) : base(dbContext)
        {
            this.finder = finder;
            this.mapper = mapper;
        }

        public async Task<CreatedErc721aUnitModel> CreateAsync(CreateErc721aUnitModel unitModel, User user)
        {
            await this.ValidateErc721aUnitCreateInputAsync(unitModel);

            var unit = mapper.Map<Erc721aUnit>(unitModel);

            await CreateEntityAsync(unit, user.Id);

            return mapper.Map<CreatedErc721aUnitModel>(unit);
        }

        public async Task<EditedErc721aUnitModel> EditAsync(EditErc721aUnitModel unitModel, int unitId, int modifierId)
        {
            var unit = await this.GetErc721aUnitAsync(unitId);

            unit.Name = unitModel.Name ?? unit.Name;

            await SaveModificationAsync(unit, modifierId);

            return mapper.Map<EditedErc721aUnitModel>(unit);
        }

        public async Task<DeletedErc721aUnitModel> DeleteAsync(int unitId, int modifierId)
        {
            var unit = await this.GetErc721aUnitAsync(unitId);

            await DeleteEntityAsync(unit, modifierId);

            return mapper.Map<DeletedErc721aUnitModel>(unit);
        }

        public async Task<Erc721aUnitListingModel> GetByIdAsync(int unitId)
        {
            var unit = await this.GetErc721aUnitAsync(unitId);

            return mapper.Map<Erc721aUnitListingModel>(unit);
        }

        public async Task<int> GetUnitNetworkIdAsync(int profileId)
        {
            var profile = await this.finder.FindByIdOrDefaultAsync<Profile>(profileId)
                ?? throw new ResourceNotFoundException(string.Format(
                    ErrorMessages.EntityDoesNotExist,
                    typeof(Profile).Name));

            return profile.Contract.NetworkId;
        }

        public async Task<IEnumerable<Erc721aUnitListingModel>> GetAllActiveErc721aUnitsAsync()
        {
            var allUnits = await this.finder.GetAllAsync<Erc721aUnit>();

            return mapper.Map<ICollection<Erc721aUnitListingModel>>(allUnits.Where(x => !x.Deleted)).ToList();
        }

        private async Task<Erc721aUnit> GetErc721aUnitAsync(int unitId)
        {
            var unit = await this.finder.FindByIdOrDefaultAsync<Erc721aUnit>(unitId);

            if (unit != null)
                return unit;

            throw new ResourceNotFoundException(string.Format(
                ErrorMessages.EntityDoesNotExist, typeof(Erc721aUnit).Name));
        }

        private async Task ValidateErc721aUnitCreateInputAsync(CreateErc721aUnitModel erc721aUnitModel)
        {
            var IsErc721aUnitExists = await this.finder.AnyByStringAsync<Erc721aUnit>(erc721aUnitModel.Name);
            if (IsErc721aUnitExists)
                throw new ResourceAlreadyExistsException(string.Format(
                    ErrorMessages.NamedEntityAlreadyExists,
                    typeof(Erc721aUnit).Name, erc721aUnitModel.Name));

            var IsProfileExists = await this.finder.AnyByIdAsync<Profile>(erc721aUnitModel.ProfileId);
            if (IsProfileExists)
                throw new ResourceNotFoundException(string.Format(
                    ErrorMessages.EntityDoesNotExist,
                    typeof(Profile).Name));
        }

        public async Task<ClaimedUnitModel> ClaimAsync(ClaimUnitModel claimUnitModel, User user)
        {
            var profile = await this.finder.FindByIdOrDefaultAsync<Profile>(claimUnitModel.ProfileId);

            var claimedUnit = profile.Erc721aUnits.FirstOrDefault(x => x.HolderId is null);

            return mapper.Map<ClaimedUnitModel>(claimedUnit);
        }

        public async Task<Profile> GetUnitProfileIdAsync(int unitId)
        {
            var unit = await this.GetErc721aUnitAsync(unitId);
            return unit.Profile;
        }

        public async Task<TransferedUnitModel> TransferAsync(TransferUnitModel transferUnitmodel, User user)
        {
            var unit = await this.GetErc721aUnitAsync(transferUnitmodel.UnitId);
            var newWalletHolder = await this.finder.FindByStringOrDefaultAsync<Wallet>(transferUnitmodel.TargetWalletAddress);
            unit.HolderId = newWalletHolder.Id;

            return mapper.Map<TransferedUnitModel>(unit);
        }

        public async Task<BoughtUnitModel> BuyAsync(BuyUnitModel buyUnitModel, User user)
        {
            var unit = await this.GetErc721aUnitAsync(buyUnitModel.UnitId);

            if (unit.Listed)
            return mapper.Map<BoughtUnitModel>(unit);

            throw new Exception(string.Format(ErrorMessages.UnitNotForSale, typeof(Erc721aUnit).Name, buyUnitModel.UnitId));
        }

        public async Task<ListedSellUnitModel> ListForSellAsync(ListSellUnitModel listSellUnitModel, User user)
        {
            var unit = await this.GetErc721aUnitAsync(listSellUnitModel.UnitId);

            if (!unit.Listed)
            {
                unit.Listed = true;

                await this.SaveModificationAsync(unit, user.Id);
            }


            throw new Exception(string.Format(ErrorMessages.UnitAlreadyListedForSale, typeof(Erc721aUnit).Name, listSellUnitModel.UnitId));
        }
    }
}
