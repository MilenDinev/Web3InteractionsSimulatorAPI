namespace JaxWorld.Services.Main
{
    using AutoMapper;
    using Base;
    using Data;
    using Data.Entities.Blockchain.Contracts;
    using Models.Requests.BlockchainRequests.ContractModels;

    internal class ContractService : BaseService<Contract>
    {
        private readonly IMapper mapper;

        public ContractService(JaxWorldDbContext dbContext, IMapper mapper) : base(dbContext)
        {
            this.mapper = mapper;
        }

        public async Task<Contract> CreateAsync(CreateContractModel contractModel, int creatorId)
        {
            var contract = mapper.Map<Contract>(contractModel);
            await CreateEntityAsync(contract, creatorId);
            return contract;
        }

        public async Task EditAsync(Contract contract, EditContractModel contractModel, int modifierId)
        {
            contract.Name = contractModel.Name;

            await SaveModificationAsync(contract, modifierId);
        }
        public async Task DeleteAsync(Contract contract, int modifierId)
        {
            await DeleteEntityAsync(contract, modifierId);
        }
    }
}
