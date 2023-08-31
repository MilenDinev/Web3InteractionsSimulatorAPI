namespace JaxWorld.Web.Controllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using Base;
    using Data.Entities.Transactions;
    using Services.Main.Interfaces;
    using Services.Handlers.Interfaces;
    using Models.Responses.BlockchainResponses.TransactionModels;

    // For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : JaxWorldBaseController
    {
        private readonly ITransactionService transactionService;
        private readonly IFinder finder;
        private readonly IValidator validator;
        private readonly IMapper mapper;

        public TransactionsController(ITransactionService transactionService,
            IFinder finder,
            IValidator validator,
            IMapper mapper,
            IUserService userService)
            : base(userService)
        {
            this.transactionService = transactionService;
            this.finder = finder;
            this.validator = validator;
            this.mapper = mapper;
        }

        // GET: api/<TransactionsController>
        [HttpGet("List/")]
        public async Task<ActionResult<IEnumerable<TransactionListingModel>>> Get()
        {
            var allTransactions = await this.finder.GetAllActiveAsync<Transaction>();

            return mapper.Map<ICollection<TransactionListingModel>>(allTransactions).ToList();
        }

        // GET api/<TransactionsController>/Transaction/5
        [HttpGet("Get/Transaction/{transactionId}")]
        public async Task<ActionResult<TransactionListingModel>> GetById(int transactionId)
        {
            var transaction = await this.finder.FindByIdOrDefaultAsync<Transaction>(transactionId);
            await this.validator.ValidateEntityAsync(transaction, transactionId.ToString());

            return mapper.Map<TransactionListingModel>(transaction);
        }
    }
}
