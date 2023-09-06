namespace JaxWorld.Services.Main.Properties
{
    using AutoMapper;
    using Base;
    using Handlers.Interfaces;
    using Interfaces.Properties;
    using Data;
    using Models.Requests.BlockchainRequests.PropertiesModels;
    using Models.Responses.BlockchainResponses.PropertiesModels.Attribute;
    using Attribute = Data.Entities.Properties.Attribute;
    using JaxWorld.Services.Main.Interfaces.Base;

    public class AttributeService : BaseService<Attribute>, IAttributeService
    {
        private readonly IFinder finder;
        private readonly IValidator validator;
        private readonly IMapper mapper;

        public AttributeService(JaxWorldDbContext dbContext,
            IFinder finder,
            IValidator validator,
            IMapper mapper) : base(dbContext)
        {
            this.finder = finder;
            this.validator = validator;
            this.mapper = mapper;
        }

        public async Task<CreatedAttributeModel> CreateAsync(CreateAttributeModel аttributeModel, int creatorId)
        {

            var аttribute = await finder.FindByStringOrDefaultAsync<Attribute>(аttributeModel.TraitType);
            await validator.ValidateUniqueEntityAsync(аttribute);

            аttribute = mapper.Map<Attribute>(аttributeModel);

            await CreateEntityAsync(аttribute, creatorId);

            return mapper.Map<CreatedAttributeModel>(аttribute); ;
        }

        public async Task<EditedAttributeModel> EditAsync(EditAttributeModel аttributeModel, int аttributeId, int modifierId)
        {
            var аttribute = await finder.FindByIdOrDefaultAsync<Attribute>(аttributeId);
            await validator.ValidateTargetEntityAvailabilityAsync(аttribute);

            аttribute.Value = аttributeModel.Value ?? аttribute.Value;

            await SaveModificationAsync(аttribute, modifierId);

            return mapper.Map<EditedAttributeModel>(аttribute);
        }

        public async Task<DeletedAttributeModel> DeleteAsync(int аttributeId, int modifierId)
        {
            var аttribute = await finder.FindByIdOrDefaultAsync<Attribute>(аttributeId);

            await validator.ValidateTargetEntityAvailabilityAsync(аttribute);

            await DeleteEntityAsync(аttribute, modifierId);

            return mapper.Map<DeletedAttributeModel>(аttribute);
        }

        public async Task<AttributeListingModel> GetByIdAsync(int аttributeId)
        {
            var аttribute = await this.finder.FindByIdOrDefaultAsync<Attribute>(аttributeId);
            await this.validator.ValidateTargetEntityAvailabilityAsync(аttribute);

            return mapper.Map<AttributeListingModel>(аttribute);
        }

        public async Task<IEnumerable<AttributeListingModel>> GetAllActiveAsync()
        {
            var allAttributes = await this.finder.GetAllActiveAsync<Attribute>();

            return mapper.Map<ICollection<AttributeListingModel>>(allAttributes).ToList();
        }

        public Task EditAsync(Attribute property, EditAttributeModel model, int modifierId)
        {
            throw new NotImplementedException();
        }

        Task<Attribute> IPropertyService<Attribute, CreateAttributeModel, EditAttributeModel>.CreateAsync(CreateAttributeModel model, int creatorId)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Attribute property, int modifierId)
        {
            throw new NotImplementedException();
        }
    }
}