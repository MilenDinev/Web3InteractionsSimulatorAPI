namespace JaxWorld.Services.Main.Properties
{
    using AutoMapper;
    using Base;
    using Data;
    using Data.Entities.Properties;
    using Handlers.Interfaces;
    using Interfaces.Properties;
    using Models.Responses.BlockchainResponses.PropertiesModels.Utility;
    using Constants;
    using Handlers.Exceptions;
    using Models.Requests.BlockchainRequests.PropertiesModels;

    public class UtilityService : BaseService<Utility>, IUtilityService
    {
        private readonly IFinder finder;
        private readonly IMapper mapper;

        public UtilityService(JaxWorldDbContext dbContext,
            IFinder finder,
            IMapper mapper) : base(dbContext)
        {
            this.finder = finder;
            this.mapper = mapper;
        }

        public async Task<CreatedUtilityModel> CreateAsync(CreateUtilityModel utilityModel, int creatorId)
        {

            await ValidateUtilityCreateInputAsync(utilityModel.TraitType);

            var utility = mapper.Map<Utility>(utilityModel);

            await CreateEntityAsync(utility, creatorId);

            return mapper.Map<CreatedUtilityModel>(utility); ;
        }

        public async Task<EditedUtilityModel> EditAsync(EditUtilityModel utilityModel, int utilityId, int modifierId)
        {
            var utility = await this.GetUtilityAsync(utilityId);

            utility.Value = utilityModel.Value ?? utility.Value;

            await SaveModificationAsync(utility, modifierId);

            return mapper.Map<EditedUtilityModel>(utility);
        }

        public async Task<DeletedUtilityModel> DeleteAsync(int utilityId, int modifierId)
        {
            var utility = await this.GetUtilityAsync(utilityId);


            await DeleteEntityAsync(utility, modifierId);

            return mapper.Map<DeletedUtilityModel>(utility);
        }

        public async Task<UtilityListingModel> GetByIdAsync(int utilityId)
        {
            var utility = await this.GetUtilityAsync(utilityId);

            return mapper.Map<UtilityListingModel>(utility);
        }

        public async Task<IEnumerable<UtilityListingModel>> GetAllActiveUtillitiesAsync()
        {
            var allUtilities = await this.finder.GetAllAsync<Utility>();

            return mapper.Map<ICollection<UtilityListingModel>>(allUtilities.Where(x => !x.Deleted)).ToList();
        }

        private async Task<Utility> GetUtilityAsync(int utilityId)
        {
            var utility = await this.finder.FindByIdOrDefaultAsync<Utility>(utilityId);

            if (utility != null)
                return utility;

            throw new ResourceNotFoundException(string.Format(
                ErrorMessages.EntityDoesNotExist, typeof(Utility).Name));
        }

        private async Task ValidateUtilityCreateInputAsync(string traitType)
        {
            var isAnyUtility = await this.finder.AnyByStringAsync<Utility>(traitType);
            if (isAnyUtility)
                throw new ResourceAlreadyExistsException(string.Format(
                    ErrorMessages.NamedEntityAlreadyExists,
                    typeof(Utility).Name, traitType));
        }

    }
}
