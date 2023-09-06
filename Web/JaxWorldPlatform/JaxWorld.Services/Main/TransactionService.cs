namespace JaxWorld.Services.Main
{
    using System.Globalization;
    using Microsoft.AspNetCore.Identity;
    using AutoMapper;
    using Base;
    using Interfaces;
    using Handlers.Interfaces;
    using Data;
    using Data.Entities.Transactions;
    using Models.Requests.BlockchainRequests.TransactionModels;
    using Models.Responses.BlockchainResponses.TransactionModels;

    public class TransactionService : BaseService<Transaction>, ITransactionService
    {
        private readonly IFinder finder;
        private readonly IValidator validator;
        private readonly IMapper mapper;

        public TransactionService(JaxWorldDbContext dbContext,
            IFinder finder,
            IValidator validator,
            IMapper mapper) : base(dbContext)
        {
            this.finder = finder;
            this.validator = validator;
            this.mapper = mapper;
        }

        public async Task<Transaction> CreateAsync(CreateTransactionModel transactionModel, int targetContractId)
        {
            transactionModel.TxnHash = await CreateTxnHashAsync(Guid.NewGuid().ToString());

            var transaction = mapper.Map<Transaction>(transactionModel);

            transaction.InitiatorId = transactionModel.InitiatorWalletId;
            transaction.TargetId = targetContractId;

            await CreateEntityAsync(transaction, transactionModel.CreatorId);

            return transaction;
        }

        public async Task<TransactionListingModel> GetByIdAsync(int transactionId)
        {
            var transaction = await this.finder.FindByIdOrDefaultAsync<Transaction>(transactionId);
            await this.validator.ValidateTargetEntityAvailabilityAsync(transaction);

            return mapper.Map<TransactionListingModel>(transaction);
        }

        public async Task<IEnumerable<TransactionListingModel>> GetAllActiveAsync()
        {
            var allTransactions = await this.finder.GetAllActiveAsync<Transaction>();

            return mapper.Map<ICollection<TransactionListingModel>>(allTransactions).ToList();
        }

        public async Task UpdateStateAsync(Transaction transaction, int modifierId)
        {
            var transactionState = await dbContext.TransactionStates.FindAsync(transaction.StateId+1);

            if (transactionState != null)
            {
                transaction.State = transactionState ;
                await SaveModificationAsync(transaction, modifierId);
            }
        }

        private static async Task<string> CreateTxnHashAsync(string hashKey)
        {
            var hasher = new PasswordHasher<string>();
            var timestamp = DateTime.UtcNow.ToString("F", CultureInfo.InvariantCulture);
            var txnHash = hasher.HashPassword(hashKey, timestamp);

            return await Task.Run(txnHash.ToString);
        }
    }
}