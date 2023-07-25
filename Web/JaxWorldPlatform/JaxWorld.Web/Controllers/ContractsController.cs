namespace JaxWorld.Web.Controllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using Base;
    using Services.Main.Interfaces;
    using Services.Handlers.Interfaces;
    using Data.Entities.Blockchain.Contracts;
    using Models.Requests.BlockchainRequests.ContractModels;
    using Models.Responses.BlockchainResponses.ContractModels;

    // For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

    [Route("api/[controller]")]
    [ApiController]
    public class ContractsController : JaxWorldBaseController
    {
        private readonly IContractService contractService;
        private readonly IFinder finder;
        private readonly IValidator validator;
        private readonly IMapper mapper;

        public ContractsController(IContractService contractService,
            IFinder finder,
            IValidator validator,
            IMapper mapper,
            IUserService userService)
            : base(userService)
        {
            this.contractService = contractService;
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
            await this.validator.ValidateEntityAsync(contract, contractId.ToString());
            return mapper.Map<ContractListingModel>(contract);
        }

        // POST api/<ContractsController/Add>
        [HttpPost("Add/")]
        public async Task<ActionResult> Create(CreateContractModel contractInput)
        {
            await AssignCurrentUserAsync();
            var contract = await this.finder.FindByStringOrDefaultAsync<Contract>(contractInput.Name);
            await this.validator.ValidateUniqueEntityAsync(contract);

            contract = await this.contractService.CreateAsync(contractInput, CurrentUser.Id);
            var createdContract = mapper.Map<CreatedContractModel>(contract);

            return CreatedAtAction(nameof(Get), "Contracts", new { id = createdContract.Id }, createdContract);
        }

        // PUT api/<ContractsController>/5
        [HttpPut("Edit/Contract/{contractId}")]
        public async Task<ActionResult<EditedContractModel>> Edit(EditContractModel contractInput, int contractId)
        {
            await AssignCurrentUserAsync();

            var contract = await this.finder.FindByIdOrDefaultAsync<Contract>(contractId);
            await this.validator.ValidateEntityAsync(contract, contractId.ToString());

            await this.contractService.EditAsync(contract, contractInput, CurrentUser.Id);

            return mapper.Map<EditedContractModel>(contract);
        }

        // DELETE api/<ContractsController>/Network/5
        [HttpDelete("Delete/Contract/{contractId}")]
        public async Task<DeletedContractModel> Delete(int contractId)
        {
            await AssignCurrentUserAsync();
            var contract = await this.finder.FindByIdOrDefaultAsync<Contract>(contractId);
            await this.validator.ValidateEntityAsync(contract, contractId.ToString());
            await this.contractService.DeleteAsync(contract, CurrentUser.Id);
            return mapper.Map<DeletedContractModel>(contract);
        }
    }
}