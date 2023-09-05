namespace JaxWorld.Web.Controllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using Base;
    using Data.Entities;
    using Data.Entities.Wallets;
    using Data.Entities.Contracts;
    using Services.Main.Interfaces;
    using Services.Handlers.Interfaces;
    using Models.Requests.BlockchainRequests.ContractModels;
    using Models.Responses.BlockchainResponses.ContractModels;

    // For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

    [Route("api/[controller]")]
    [ApiController]
    public class ContractsController : JaxWorldBaseController
    {
        private readonly IContractService contractService;
        private readonly ITransactionDeployer transactionDeployer;
        private readonly IFinder finder;
        private readonly IValidator validator;
        private readonly IMapper mapper;

        public ContractsController(IContractService contractService,
            ITransactionDeployer transactionDeployer,
            IFinder finder,
            IValidator validator,
            IMapper mapper,
            IUserService userService)
            : base(userService)
        {
            this.contractService = contractService;
            this.transactionDeployer = transactionDeployer;
            this.finder = finder;
            this.validator = validator;
            this.mapper = mapper;
        }

        // GET: api/<ContractsController>
        [HttpGet("List/")]
        public async Task<ActionResult<IEnumerable<ContractListingModel>>> Get()
        {
            var allContracts = await this.finder.GetAllActiveAsync<Contract>();

            return mapper.Map<ICollection<ContractListingModel>>(allContracts).ToList();
        }

        // GET api/<ContractsController>/Contract/5
        [HttpGet("Get/Contract/{contractId}")]
        public async Task<ActionResult<ContractListingModel>> GetById(int contractId)
        {
            var contract = await this.finder.FindByIdOrDefaultAsync<Contract>(contractId);
            await this.validator.ValidateEntityAsync(contract);

            return mapper.Map<ContractListingModel>(contract);
        }

        // POST api/<ContractsController/Deploy>
        [HttpPost("Deploy/")]
        public async Task<ActionResult> Post(CreateContractModel contractInput)
        {
            await AssignCurrentUserAsync();

            var contract = await this.finder.FindByStringOrDefaultAsync<Contract>(contractInput.Name);
            await this.validator.ValidateUniqueEntityAsync(contract);

            var network = await this.finder.FindByIdOrDefaultAsync<Network>(contractInput.NetworkId);
            await this.validator.ValidateEntityAsync(network);

            var wallet = await this.finder.FindByStringOrDefaultAsync<Wallet>(contractInput.CreatorAddress);
            await this.validator.ValidateEntityAsync(wallet);

            await this.validator.ValidateWalletOwnershipAsync(CurrentUser, wallet);

            wallet.IsActive = true;

            var createdContract = await this.contractService.CreateAsync(contractInput, wallet.Id, CurrentUser.Id);

            var deployedContract = await this.transactionDeployer.DeployContractTxnAsync(createdContract, CurrentUser.Id);

            return CreatedAtAction(nameof(Get), "Contracts", new { id = deployedContract.ContractId }, deployedContract);
        }

        // PUT api/<ContractsController>/5
        [HttpPut("Edit/Contract/{contractId}")]
        public async Task<ActionResult<EditedContractModel>> Put(EditContractModel contractInput, int contractId)
        {
            await AssignCurrentUserAsync();

            var contract = await this.finder.FindByIdOrDefaultAsync<Contract>(contractId);

            await this.validator.ValidateEntityAsync(contract);
            await this.contractService.EditAsync(contract, contractInput, CurrentUser.Id);

            return mapper.Map<EditedContractModel>(contract);
        }

        // DELETE api/<ContractsController>/Network/5
        [HttpDelete("Delete/Contract/{contractId}")]
        public async Task<DeletedContractModel> Delete(int contractId)
        {
            await AssignCurrentUserAsync();

            var contract = await this.finder.FindByIdOrDefaultAsync<Contract>(contractId);

            await this.validator.ValidateEntityAsync(contract);
            await this.contractService.DeleteAsync(contract, CurrentUser.Id);

            return mapper.Map<DeletedContractModel>(contract);
        }
    }
}