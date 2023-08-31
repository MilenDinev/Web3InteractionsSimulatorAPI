namespace JaxWorld.Services.Main.Interfaces
{
    using Data.Entities.Transactions;
    using Models.Requests.BlockchainRequests.TransactionModels;

    public interface ITransactionService
    {
        public Task<Transaction> CreateAsync(CreateTransactionModel model, int creatorId);
    }
}
