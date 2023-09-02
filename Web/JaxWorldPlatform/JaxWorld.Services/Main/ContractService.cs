namespace JaxWorld.Services.Main
{
    using AutoMapper;
    using Base;
    using Interfaces;
    using Data;
    using Data.Entities.Contracts;
    using Models.Requests.BlockchainRequests.ContractModels;

    public class ContractService : BaseService<Contract>, IContractService
    {
        private readonly IMapper mapper;

        public ContractService(JaxWorldDbContext dbContext, IMapper mapper) : base(dbContext)
        {
            this.mapper = mapper;
        }

        public async Task<Contract> CreateAsync(CreateContractModel contractModel, int creatorId)
        {
            var contract = mapper.Map<Contract>(contractModel);

            var contractAddress = await CreateContractAddressAsync(contractModel.Name);
            contract.Address = contractAddress;

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
