namespace JaxWorld.Web.Controllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using Base;
    using Services.Handlers.Interfaces;
    using Services.Main.Interfaces;
    using Services.Managers.Interfaces;
    using Data.Entities.Contracts;
    using Models.Requests.BlockchainRequests.ContractModels;
    using Models.Responses.BlockchainResponses.ContractModels;

    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsDeployerController : JaxWorldBaseController
    {
        private readonly ITransactionDeployer transactionDeployer;
        private readonly IFinder finder;
        private readonly IValidator validator;
        private readonly IMapper mapper;

        public TransactionsDeployerController(ITransactionDeployer transactionDeployer,
            IFinder finder,
            IValidator validator,
            IMapper mapper,
            IUserService userService)
            : base(userService)
        {
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


        // POST api/<TransactionsDeployerController/DeployContract>
        [HttpPost("DeployContract/")]
        public async Task<ActionResult> DeployContract(CreateContractModel contractInput)
        {
            await AssignCurrentUserAsync();

            var contract = await this.finder.FindByStringOrDefaultAsync<Contract>(contractInput.Name);
            await this.validator.ValidateUniqueEntityAsync(contract);

            var deployedContract = await this.transactionDeployer.DeployContractAsync(contractInput, CurrentUser.Id);


            return CreatedAtAction(nameof(Get), "TransactionsDeployer", new { id = deployedContract.ContractId }, deployedContract);
        }
    }
}