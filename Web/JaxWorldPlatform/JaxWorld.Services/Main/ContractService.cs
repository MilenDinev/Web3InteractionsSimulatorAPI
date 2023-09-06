namespace JaxWorld.Services.Main
{
    using AutoMapper;
    using System.Globalization;
    using Microsoft.AspNetCore.Identity;
    using Base;
    using Interfaces;
    using Handlers.Interfaces;
    using Data;
    using Data.Entities;
    using Data.Entities.Wallets;
    using Data.Entities.Contracts;
    using Models.Requests.BlockchainRequests.ContractModels;
    using Models.Responses.BlockchainResponses.ContractModels;

    public class ContractService : BaseService<Contract>, IContractService
    {
        private readonly IFinder finder;
        private readonly IValidator validator;
        private readonly IMapper mapper;

        public ContractService(JaxWorldDbContext dbContext,
            IFinder finder,
            IValidator validator,
            IMapper mapper) : base(dbContext)
        {
            this.finder = finder;
            this.validator = validator;
            this.mapper = mapper;
        }

        public async Task<CreatedContractModel> CreateAsync(CreateContractModel contractModel, User user)
        {

            var contract = await this.finder.FindByStringOrDefaultAsync<Contract>(contractModel.Name);
            await this.validator.ValidateUniqueEntityAsync(contract);

            var network = await this.finder.FindByIdOrDefaultAsync<Network>(contractModel.NetworkId);
            await this.validator.ValidateTargetEntityAvailabilityAsync(network);

            var wallet = await this.finder.FindByStringOrDefaultAsync<Wallet>(contractModel.CreatorAddress);
            await this.validator.ValidateTargetEntityAvailabilityAsync(wallet);
            

            await this.validator.ValidateWalletOwnershipAsync(user, wallet);

            wallet.IsActive = true;

            contract = mapper.Map<Contract>(contractModel);
            contract.CreatorWalletId = wallet.Id;

            var contractAddress = await CreateContractAddressAsync(contractModel.Name);
            contract.Address = contractAddress;

            await CreateEntityAsync(contract, user.Id);

            var createdContract = mapper.Map<CreatedContractModel>(contract);

            return createdContract;
        }

        public async Task<EditedContractModel> EditAsync(EditContractModel contractModel, int contractId, int modifierId)
        {

            var contract = await this.finder.FindByIdOrDefaultAsync<Contract>(contractId);

            await this.validator.ValidateTargetEntityAvailabilityAsync(contract);

            contract.Name = contractModel.Name;

            await SaveModificationAsync(contract, modifierId);

            return mapper.Map<EditedContractModel>(contract);
        }

        public async Task<DeletedContractModel> DeleteAsync(int contractId, int modifierId)
        {

            var contract = await this.finder.FindByIdOrDefaultAsync<Contract>(contractId);

            await this.validator.ValidateTargetEntityAvailabilityAsync(contract);

            await DeleteEntityAsync(contract, modifierId);

            return mapper.Map<DeletedContractModel>(contract);
        }

        public async Task<ContractListingModel> GetByIdAsync(int contractId)
        {
            var contract = await this.finder.FindByIdOrDefaultAsync<Contract>(contractId);
            await this.validator.ValidateTargetEntityAvailabilityAsync(contract);

            return mapper.Map<ContractListingModel>(contract);
        }

        public async Task<IEnumerable<ContractListingModel>> GetAllActiveAsync()
        {
            var allContracts = await this.finder.GetAllActiveAsync<Contract>();

            return mapper.Map<ICollection<ContractListingModel>>(allContracts).ToList();
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