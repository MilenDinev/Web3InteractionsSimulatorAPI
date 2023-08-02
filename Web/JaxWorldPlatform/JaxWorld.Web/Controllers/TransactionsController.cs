namespace JaxWorld.Web.Controllers
{
    using AutoMapper;
    using Base;
    using Services.Handlers.Interfaces;
    using Services.Main.Interfaces;
    using Microsoft.AspNetCore.Mvc;
    using Data.Entities.Blockchain.Transactions;
    using Models.Requests.BlockchainRequests.TransactionModels;
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

        // POST api/<TransactionsController/Add>
        [HttpPost("Add/")]
        public async Task<ActionResult> Create(CreateTransactionModel transactionInput)
        {
            await AssignCurrentUserAsync();
            var transaction = await this.finder.FindByStringOrDefaultAsync<Transaction>(transactionInput.State);
            await this.validator.ValidateUniqueEntityAsync(transaction);

            transaction = await this.transactionService.CreateAsync(transactionInput, CurrentUser.Id);
            var createdTransaction = mapper.Map<CreatedTransactionModel>(transaction);

            return CreatedAtAction(nameof(Get), "Transactions", new { id = createdTransaction.Id }, createdTransaction);
        }

        // PUT api/<TransactionsController>/5
        [HttpPut("Edit/Transaction/{transactionId}")]
        public async Task<ActionResult<EditedTransactionModel>> Edit(EditTransactionModel transactionInput, int transactionId)
        {
            await AssignCurrentUserAsync();

            var transaction = await this.finder.FindByIdOrDefaultAsync<Transaction>(transactionId);
            await this.validator.ValidateEntityAsync(transaction, transactionId.ToString());

            await this.transactionService.EditAsync(transaction, transactionInput, CurrentUser.Id);

            return mapper.Map<EditedTransactionModel>(transaction);
        }

        // DELETE api/<TransactionsController>/Transaction/5
        [HttpDelete("Delete/Transaction/{transactionId}")]
        public async Task<DeletedTransactionModel> Delete(int transactionId)
        {
            await AssignCurrentUserAsync();
            var transaction = await this.finder.FindByIdOrDefaultAsync<Transaction>(transactionId);
            await this.validator.ValidateEntityAsync(transaction, transactionId.ToString());
            await this.transactionService.DeleteAsync(transaction, CurrentUser.Id);
            return mapper.Map<DeletedTransactionModel>(transaction);
        }
    }
}
