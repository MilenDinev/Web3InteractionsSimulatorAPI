namespace JaxWorld.Services.Main
{
    using System.Globalization;
    using Microsoft.AspNetCore.Identity;
    using AutoMapper;
    using Interfaces;
    using Constants;
    using Base;
    using Handlers.Exceptions;
    using Handlers.Interfaces;
    using Data;
    using Data.Entities;
    using Data.Entities.Contracts;
    using Models.Requests.BlockchainRequests.ContractModels;
    using Models.Responses.BlockchainResponses.ContractModels;

    public class ContractService : BaseService<Contract>, IContractService
    {
        private readonly IFinder finder;
        private readonly IMapper mapper;

        public ContractService(JaxWorldDbContext dbContext,
            IFinder finder,
            IMapper mapper) : base(dbContext)
        {
            this.finder = finder;
            this.mapper = mapper;
        }

        public async Task<CreatedContractModel> CreateAsync(CreateContractModel contractModel, User user)
        {
            await this.ValidateCreateInputAsync(contractModel);

            var contract = mapper.Map<Contract>(contractModel);

            contract.CreatorWalletId = user.WalletId;
            contract.Address = await CreateContractAddressAsync(contractModel.Name);

            await CreateEntityAsync(contract, user.Id);

            return mapper.Map<CreatedContractModel>(contract);
        }

        public async Task<EditedContractModel> EditAsync(EditContractModel contractModel, int contractId, int modifierId)
        {
            var contract = await GetContractAsync(contractId);

            contract.Name = contractModel.Name ?? contract.Name;

            await SaveModificationAsync(contract, modifierId);

            return mapper.Map<EditedContractModel>(contract);
        }

        public async Task<DeletedContractModel> DeleteAsync(int contractId, int modifierId)
        {
            var contract = await GetContractAsync(contractId);

            await DeleteEntityAsync(contract, modifierId);

            return mapper.Map<DeletedContractModel>(contract);
        }

        public async Task<ContractListingModel> GetByIdAsync(int contractId)
        {
            var contract = await GetContractAsync(contractId);

            return mapper.Map<ContractListingModel>(contract);
        }

        public async Task<IEnumerable<ContractListingModel>> GetAllActiveContractsAsync()
        {
            var allContracts = await this.finder.GetAllAsync<Contract>();

            return mapper.Map<ICollection<ContractListingModel>>(allContracts.Where(x => !x.Deleted)).ToList();
        }

        private async Task<string> CreateContractAddressAsync(string hashKey)
        {
            var hasher = new PasswordHasher<string>();
            var timestamp = DateTime.UtcNow.ToString("F", CultureInfo.InvariantCulture);
            var address = hasher.HashPassword(hashKey, timestamp);

            return await Task.Run(address.ToString);
        }

        private async Task<Contract> GetContractAsync(int contractId)
        {
            var contract = await this.finder.FindByIdOrDefaultAsync<Contract>(contractId);

            if (contract != null)
                return contract;

            throw new ResourceNotFoundException(string.Format(
                ErrorMessages.EntityDoesNotExist, typeof(Contract).Name));
        }

        private async Task ValidateCreateInputAsync(CreateContractModel contractModel)
        {
            var isAnyContract = await this.finder.AnyByStringAsync<Contract>(contractModel.Name);
            if (isAnyContract)
                throw new ResourceAlreadyExistsException(string.Format(
                    ErrorMessages.NamedEntityAlreadyExists,
                    typeof(Contract).Name, contractModel.Name));
        }
    }
}