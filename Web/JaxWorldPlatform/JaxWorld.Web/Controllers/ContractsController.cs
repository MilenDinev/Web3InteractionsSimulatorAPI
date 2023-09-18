namespace JaxWorld.Web.Controllers
{
    using Base;
    using JaxWorld.Services.Handlers.Interfaces;
    using Microsoft.AspNetCore.Mvc;
    using Models.Requests.BlockchainRequests.ContractModels;
    using Models.Responses.BlockchainResponses.ContractModels;
    using Services.Main.Interfaces;

    // For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

    [Route("api/[controller]")]
    [ApiController]
    public class ContractsController : JaxWorldBaseController
    {
        private readonly IContractService contractService;
        private readonly IContractTxnDeployer contractTransactionDeployer;
        
        public ContractsController(IContractService contractService,
            IContractTxnDeployer contractTransactionDeployer,
            IUserService userService)
            : base(userService)
        {
            this.contractService = contractService;
            this.contractTransactionDeployer = contractTransactionDeployer;

        }

        // GET: api/<ContractsController>
        [HttpGet("List/")]
        public async Task<ActionResult<IEnumerable<ContractListingModel>>> Get()
        {
            var allContracts = await this.contractService.GetAllActiveContractsAsync();

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

            var createdContract = await this.contractTransactionDeployer.DeployContractTxnAsync(contractInput, CurrentUser);

            return CreatedAtAction(nameof(Get), "Contracts", new { id = createdContract.Id }, createdContract);
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