using AutoMapper;
using JaxWorld.Data;
using JaxWorld.Models.Requests.BlockchainRequests.ContractModels;
using JaxWorld.Services.Base;
using Attribute = JaxWorld.Data.Entities.Blockchain.Properties.Attribute;

namespace JaxWorld.Services.Main
{
    internal class AttributeService : BaseService<Attribute>
    {
        private readonly IMapper mapper;

        public AttributeService(JaxWorldDbContext dbContext, IMapper mapper) : base(dbContext)
        {
            this.mapper = mapper;
        }

        public async Task<Attribute> CreateAsync(CreateContractModel contractModel, int creatorId)
        {
            var contract = mapper.Map<Attribute>(contractModel);
            await CreateEntityAsync(contract, creatorId);
            return contract;
        }

        public async Task EditAsync(Attribute contract, EditContractModel contractModel, int modifierId)
        {
            contract.Value = contractModel.Name;

            await SaveModificationAsync(contract, modifierId);
        }
        public async Task DeleteAsync(Attribute contract, int modifierId)
        {
            await DeleteEntityAsync(contract, modifierId);
        }
    }
}