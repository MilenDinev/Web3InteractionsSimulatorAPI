namespace JaxWorld.Services.Main
{
    using AutoMapper;
    using Data;
    using Models.Requests.BlockchainRequests.PropertiesModels;
    using Services.Base;
    using Attribute = Data.Entities.Blockchain.Properties.Attribute;

    public class AttributeService : BaseService<Attribute>
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
    }
}