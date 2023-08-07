namespace JaxWorld.Services.Main.Properties
{
    using AutoMapper;
    using Base;
    using Interfaces.Properties;
    using Data;
    using Models.Requests.BlockchainRequests.PropertiesModels;
    using Attribute = Data.Entities.Properties.Attribute;

    public class AttributeService : BaseService<Attribute>, IAttributeService
    {
        private readonly IMapper mapper;

        public AttributeService(JaxWorldDbContext dbContext, IMapper mapper) : base(dbContext)
        {
            this.mapper = mapper;
        }

        public async Task<Attribute> CreateAsync(CreateAttributeModel attributeModel, int creatorId)
        {
            var attribute = mapper.Map<Attribute>(attributeModel);
            await CreateEntityAsync(attribute, creatorId);
            return attribute;
        }

        public async Task EditAsync(Attribute attribute, EditAttributeModel attributeModel, int modifierId)
        {
            attribute.Value = attributeModel.Value;

            await SaveModificationAsync(attribute, modifierId);
        }

        public async Task DeleteAsync(Attribute attribute, int modifierId)
        {
            await DeleteEntityAsync(attribute, modifierId);
        }
    }
}