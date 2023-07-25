namespace JaxWorld.Web.Controllers
{
    using AutoMapper;
    using JaxWorld.Data.Entities.Blockchain;
    using JaxWorld.Data.Entities.Blockchain.Contracts;
    using JaxWorld.Data.Interfaces.IEntities.IBlockchain.IContracts;
    using JaxWorld.Models.Requests.BlockchainRequests.ChainModels;
    using JaxWorld.Models.Requests.BlockchainRequests.ContractModels;
    using JaxWorld.Models.Responses.BlockchainResponses.ChainModels;
    using JaxWorld.Models.Responses.BlockchainResponses.ContractModels;
    using JaxWorld.Services.Handlers.Interfaces;
    using JaxWorld.Services.Main.Interfaces;
    using JaxWorld.Web.Controllers.Base;
    using Microsoft.AspNetCore.Mvc;

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
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ContractsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
