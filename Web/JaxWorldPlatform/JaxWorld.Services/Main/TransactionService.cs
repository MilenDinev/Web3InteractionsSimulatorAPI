namespace JaxWorld.Services.Main
{
    using AutoMapper;
    using Base;
    using Data;
    using Data.Entities.Blockchain.Transactions;
    using Models.Requests.BlockchainRequests.TransactionModels;

    internal class TransactionService : BaseService<Transaction>
    {
        private readonly IMapper mapper;

        public TransactionService(JaxWorldDbContext dbContext, IMapper mapper) : base(dbContext)
        {
            this.mapper = mapper;
        }

        public async Task<Transaction> CreateAsync(CreateTransactionModel transactionModel, int creatorId)
        {
            var transaction = mapper.Map<Transaction>(transactionModel);
            await CreateEntityAsync(transaction, creatorId);
            return transaction;
        }

        public async Task EditAsync(Transaction transaction, EditTransactionModel transactionModel, int modifierId)
        {
            transaction.State = new TransactionState
            {
                Value = transactionModel.State
        };

            await SaveModificationAsync(transaction, modifierId);
        }
        public async Task DeleteAsync(Transaction transaction, int modifierId)
        {
            await DeleteEntityAsync(transaction, modifierId);
        }
    }
}
