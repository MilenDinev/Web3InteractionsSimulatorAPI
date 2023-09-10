namespace JaxWorld.Services.Main.Properties
{
    using AutoMapper;
    using Base;
    using Data;
    using Handlers.Interfaces;
    using Interfaces.Properties;
    using Services.Constants;
    using Models.Requests.BlockchainRequests.PropertiesModels;
    using Models.Responses.BlockchainResponses.PropertiesModels.Attribute;
    using Attribute = Data.Entities.Properties.Attribute;
    using Handlers.Exceptions;

    public class AttributeService : BaseService<Attribute>, IAttributeService
    {
        private readonly IFinder finder;
        private readonly IMapper mapper;

        public AttributeService(JaxWorldDbContext dbContext,
            IFinder finder,
            IMapper mapper) : base(dbContext)
        {
            this.finder = finder;
            this.mapper = mapper;
        }

        public async Task<CreatedAttributeModel> CreateAsync(CreateAttributeModel аttributeModel, int creatorId)
        {
            await ValidateAttributeCreateInputAsync(аttributeModel.TraitType);

            var аttribute = mapper.Map<Attribute>(аttributeModel);

            await CreateEntityAsync(аttribute, creatorId);

            return mapper.Map<CreatedAttributeModel>(аttribute); ;
        }

        public async Task<EditedAttributeModel> EditAsync(EditAttributeModel аttributeModel, int аttributeId, int modifierId)
        {
            var аttribute = await this.GetAttributeAsync(аttributeId);

            аttribute.Value = аttributeModel.Value ?? аttribute.Value;

            await SaveModificationAsync(аttribute, modifierId);

            return mapper.Map<EditedAttributeModel>(аttribute);
        }

        public async Task<DeletedAttributeModel> DeleteAsync(int аttributeId, int modifierId)
        {
            var аttribute = await this.GetAttributeAsync(аttributeId);

            await DeleteEntityAsync(аttribute, modifierId);

            return mapper.Map<DeletedAttributeModel>(аttribute);
        }

        public async Task<AttributeListingModel> GetByIdAsync(int аttributeId)
        {
            var аttribute = await this.GetAttributeAsync(аttributeId);

            return mapper.Map<AttributeListingModel>(аttribute);
        }

        public async Task<IEnumerable<AttributeListingModel>> GetAllActiveAttributesAsync()
        {
            var allAttributes = await this.finder.GetAllAsync<Attribute>();

            return mapper.Map<ICollection<AttributeListingModel>>(allAttributes.Where(x => !x.Deleted)).ToList();
        }

        private async Task<Attribute> GetAttributeAsync(int attributeId)
        {
            var attribute = await this.finder.FindByIdOrDefaultAsync<Attribute>(attributeId);

            if (attribute != null)
                return attribute;

            throw new ResourceNotFoundException(string.Format(
                ErrorMessages.EntityDoesNotExist, typeof(Attribute).Name));
        }

        private async Task ValidateAttributeCreateInputAsync(string traitType)
        {
            var isAnyAttribute = await this.finder.AnyByStringAsync<Attribute>(traitType);
            if (isAnyAttribute)
                throw new ResourceAlreadyExistsException(string.Format(
                    ErrorMessages.NamedEntityAlreadyExists,
                    typeof(Attribute).Name, traitType));
        }
    }
}