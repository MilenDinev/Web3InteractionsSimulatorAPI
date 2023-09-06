namespace JaxWorld.Web.Controllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using Base;
    using Services.Main.Interfaces;
    using Models.Responses.BlockchainResponses.TransactionModels;

    // For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : JaxWorldBaseController
    {
        private readonly ITransactionService transactionService;
        private readonly IMapper mapper;

        public TransactionsController(ITransactionService transactionService,
            IMapper mapper,
            IUserService userService)
            : base(userService)
        {
            this.transactionService = transactionService;
            this.mapper = mapper;
        }

        // GET: api/<TransactionsController>
        [HttpGet("List/")]
        public async Task<ActionResult<IEnumerable<TransactionListingModel>>> Get()
        {
            var allTransactions = await this.transactionService.GetAllActiveAsync();

            return allTransactions.ToList();
        }

        // GET api/<TransactionsController>/Transaction/5
        [HttpGet("Get/Transaction/{transactionId}")]
        public async Task<ActionResult<TransactionListingModel>> GetById(int transactionId)
        {
            var transactionListingModel = await this.transactionService.GetByIdAsync(transactionId);

            return transactionListingModel;
        }
    }
}
