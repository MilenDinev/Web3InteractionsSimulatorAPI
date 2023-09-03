namespace JaxWorld.Services.Main
{
    using AutoMapper;
    using System.Globalization;
    using Microsoft.AspNetCore.Identity;
    using Base;
    using Interfaces;
    using Data;
    using Data.Entities.Contracts;
    using Models.Requests.BlockchainRequests.ContractModels;
    using Models.Responses.BlockchainResponses.ContractModels;

    public class ContractService : BaseService<Contract>, IContractService
    {
        private readonly IMapper mapper;

        public ContractService(JaxWorldDbContext dbContext, IMapper mapper) : base(dbContext)
        {
            this.mapper = mapper;
        }

        public async Task<CreatedContractModel> CreateAsync(CreateContractModel contractModel, int creatorWalletId, int creatorId)
        {
            var contract = mapper.Map<Contract>(contractModel);
            contract.CreatorWalletId = creatorWalletId;

            var contractAddress = await CreateContractAddressAsync(contractModel.Name);
            contract.Address = contractAddress;

            await CreateEntityAsync(contract, creatorId);

            var createdContract = mapper.Map<CreatedContractModel>(contract);

            return createdContract;
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


        internal async Task<string> CreateContractAddressAsync(string hashKey)
        {
            var hasher = new PasswordHasher<string>();
            var timestamp = DateTime.UtcNow.ToString("F", CultureInfo.InvariantCulture);
            var address = hasher.HashPassword(hashKey, timestamp);

            return await Task.Run(address.ToString);
        }
    }
}