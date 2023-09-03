namespace JaxWorld.Services.Main
{
    using AutoMapper;
    using Base;
    using Interfaces;
    using Data;
    using Data.Entities.Transactions;
    using Models.Requests.BlockchainRequests.TransactionModels;

    public class TransactionService : BaseService<Transaction>, ITransactionService
    {
        private readonly IMapper mapper;

        public TransactionService(JaxWorldDbContext dbContext, IMapper mapper) : base(dbContext)
        {
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

        public async Task UpdateStateAsync(Transaction transaction, int state, int modifierId)
        {
            var transactionState = await dbContext.TransactionStates.FindAsync(state);

            transaction.State = transactionState;

            await SaveModificationAsync(transaction, modifierId);
        }
    }
}