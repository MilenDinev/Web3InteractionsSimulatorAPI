namespace JaxWorld.Services.Main.Properties
{
    using AutoMapper;
    using Base;
    using Interfaces.Base;
    using Handlers.Interfaces;
    using Interfaces.Properties;
    using Data;
    using Data.Entities.Properties;
    using Models.Requests.BlockchainRequests.PropertiesModels;
    using Models.Responses.BlockchainResponses.PropertiesModels.Utility;

    public class UtilityService : BaseService<Utility>, IUtilityService
    {
        private readonly IFinder finder;
        private readonly IValidator validator;
        private readonly IMapper mapper;

        public UtilityService(JaxWorldDbContext dbContext,
            IFinder finder,
            IValidator validator,
            IMapper mapper) : base(dbContext)
        {
            this.finder = finder;
            this.validator = validator;
            this.mapper = mapper;
        }

        public async Task<CreatedUtilityModel> CreateAsync(CreateUtilityModel utilityModel, int creatorId)
        {

            var utility = await finder.FindByStringOrDefaultAsync<Utility>(utilityModel.TraitType);
            await validator.ValidateUniqueEntityAsync(utility);

            utility = mapper.Map<Utility>(utilityModel);

            await CreateEntityAsync(utility, creatorId);

            return mapper.Map<CreatedUtilityModel>(utility); ;
        }

        public async Task<EditedUtilityModel> EditAsync(EditUtilityModel utilityModel, int utilityId, int modifierId)
        {
            var utility = await finder.FindByIdOrDefaultAsync<Utility>(utilityId);
            await validator.ValidateTargetEntityAvailabilityAsync(utility);

            utility.Value = utilityModel.Value ?? utility.Value;

            await SaveModificationAsync(utility, modifierId);

            return mapper.Map<EditedUtilityModel>(utility);
        }

        public async Task<DeletedUtilityModel> DeleteAsync(int utilityId, int modifierId)
        {
            var utility = await finder.FindByIdOrDefaultAsync<Utility>(utilityId);

            await validator.ValidateTargetEntityAvailabilityAsync(utility);

            await DeleteEntityAsync(utility, modifierId);

            return mapper.Map<DeletedUtilityModel>(utility);
        }

        public async Task<UtilityListingModel> GetByIdAsync(int utilityId)
        {
            var utility = await this.finder.FindByIdOrDefaultAsync<Utility>(utilityId);
            await this.validator.ValidateTargetEntityAvailabilityAsync(utility);

            return mapper.Map<UtilityListingModel>(utility);
        }

        public async Task<IEnumerable<UtilityListingModel>> GetAllActiveAsync()
        {
            var allUtilities = await this.finder.GetAllActiveAsync<Utility>();
      
            return mapper.Map<ICollection<UtilityListingModel>>(allUtilities).ToList();
        }

        Task<Utility> IPropertyService<Utility, CreateUtilityModel, EditUtilityModel>.CreateAsync(CreateUtilityModel model, int creatorId)
        {
            throw new NotImplementedException();
        }

        public Task EditAsync(Utility property, EditUtilityModel model, int modifierId)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Utility property, int modifierId)
        {
            throw new NotImplementedException();
        }
    }
}
