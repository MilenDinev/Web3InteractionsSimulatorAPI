namespace JaxWorld.Web.Controllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using Base;
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
        private readonly IMapper mapper;

        public ContractsController(IContractService contractService,
            ITransactionDeployer transactionDeployer,
            IMapper mapper,
            IUserService userService)
            : base(userService)
        {
            this.contractService = contractService;
            this.transactionDeployer = transactionDeployer;
            this.mapper = mapper;
        }

        // GET: api/<ContractsController>
        [HttpGet("List/")]
        public async Task<ActionResult<IEnumerable<ContractListingModel>>> Get()
        {
            var allContracts = await this.contractService.GetAllActiveAsync();

            return allContracts.ToList();
        }

        // GET api/<ContractsController>/Contract/5
        [HttpGet("Get/Contract/{contractId}")]
        public async Task<ActionResult<ContractListingModel>> GetById(int contractId)
        {
            var contractListing = await this.contractService.GetByIdAsync(contractId);

            return contractListing;
        }

        // POST api/<ContractsController/Deploy>
        [HttpPost("Deploy/")]
        public async Task<ActionResult> Post(CreateContractModel contractInput)
        {
            await AssignCurrentUserAsync();

            var createdContract = await this.contractService.CreateAsync(contractInput, CurrentUser);

            var deployedContract = await this.transactionDeployer.DeployContractTxnAsync(createdContract, CurrentUser.Id);

            return CreatedAtAction(nameof(Get), "Contracts", new { id = deployedContract.ContractId }, deployedContract);
        }

        // PUT api/<ContractsController>/5
        [HttpPut("Edit/Contract/{contractId}")]
        public async Task<ActionResult<EditedContractModel>> Put(EditContractModel contractInput, int contractId)
        {
            await AssignCurrentUserAsync();

            var editedContract = await this.contractService.EditAsync(contractInput, contractId, CurrentUser.Id);

            return editedContract;
        }

        // DELETE api/<ContractsController>/Network/5
        [HttpDelete("Delete/Contract/{contractId}")]
        public async Task<DeletedContractModel> Delete(int contractId)
        {
            await AssignCurrentUserAsync();

            var deletedContract = await this.contractService.DeleteAsync(contractId, CurrentUser.Id);

            return deletedContract;
        }
    }
}