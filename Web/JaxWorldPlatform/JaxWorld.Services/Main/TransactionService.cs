namespace JaxWorld.Services.Main
{
    using System.Globalization;
    using Microsoft.AspNetCore.Identity;
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