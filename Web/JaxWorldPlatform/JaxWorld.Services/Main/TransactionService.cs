namespace JaxWorld.Services.Main
{
    using System.Globalization;
    using Microsoft.AspNetCore.Identity;
    using AutoMapper;
    using Base;
    using Data;
    using Data.Entities.Transactions;
    using Constants;
    using Interfaces;
    using Handlers.Interfaces;
    using Handlers.Exceptions;
    using Models.Requests.BlockchainRequests.TransactionModels;
    using Models.Responses.BlockchainResponses.TransactionModels;

    public class TransactionService : BaseService<Transaction>, ITransactionService
    {
        private readonly IFinder finder;
        private readonly IMapper mapper;

        public TransactionService(JaxWorldDbContext dbContext,
            IFinder finder,
            IMapper mapper) : base(dbContext)
        {
            this.finder = finder;
            this.mapper = mapper;
        }

        public async Task<Transaction> CreateAsync(CreateTransactionModel transactionModel, int? targetContractId = null)
        {

            transactionModel.TxnHash = await CreateTxnHashAsync(Guid.NewGuid().ToString());

            var transaction = mapper.Map<Transaction>(transactionModel);

            transaction.InitiatorId = transactionModel.InitiatorWalletId;
            if (targetContractId.HasValue)
            transaction.TargetId = targetContractId;

            await CreateEntityAsync(transaction, transactionModel.CreatorId);

            return transaction;
        }

        public async Task<TransactionListingModel> GetByIdAsync(int transactionId)
        {
            var transaction = await GetTransactionAsync(transactionId);

            return mapper.Map<TransactionListingModel>(transaction);
        }

        public async Task<IEnumerable<TransactionListingModel>> GetAllActiveTxnsAsync()
        {
            var allTransactions = await this.finder.GetAllAsync<Transaction>();

            return mapper.Map<ICollection<TransactionListingModel>>(allTransactions.Where(x => !x.Deleted)).ToList();
        }

        public async Task<int> GetTransactionStateIdAsync(string state)
        {
            var transactionState = await finder.FindByStringOrDefaultAsync<TransactionState>(state);

            if (transactionState != null)
                return transactionState.Id;

            throw new ResourceNotFoundException(string.Format(
                ErrorMessages.EntityDoesNotExist, typeof(Transaction).Name));
        }
            {
                transaction.State = transactionState;
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

        private async Task<Transaction> GetTransactionAsync(int txnId)
        {
            var transaction = await this.finder.FindByIdOrDefaultAsync<Transaction>(txnId);

            if (transaction != null)
                return transaction;

            throw new ResourceNotFoundException(string.Format(
                ErrorMessages.EntityDoesNotExist, typeof(Transaction).Name));
        }
    }
}