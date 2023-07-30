namespace JaxWorld.Services.Main.Interfaces
{
    using Data.Entities.Blockchain.Transactions;
    using Models.Requests.BlockchainRequests.TransactionModels;

    public interface ITransactionService
    {
        Task<Transaction> CreateAsync(CreateTransactionModel model, int creatorId);
        Task EditAsync(Transaction transaction, EditTransactionModel model, int modifierId);
        Task DeleteAsync(Transaction transaction, int modifierId);
    }
}
