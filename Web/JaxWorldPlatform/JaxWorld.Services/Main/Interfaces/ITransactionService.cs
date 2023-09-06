﻿namespace JaxWorld.Services.Main.Interfaces
{
    using Data.Entities.Transactions;
    using Models.Responses.BlockchainResponses.TransactionModels;
    using Models.Requests.BlockchainRequests.TransactionModels;

    public interface ITransactionService
    {
        Task<Transaction> CreateAsync(CreateTransactionModel model, int targetContractId);
        Task<IEnumerable<TransactionListingModel>> GetAllActiveAsync();
        Task<TransactionListingModel> GetByIdAsync(int transactionId);
        Task UpdateStateAsync(Transaction transaction, int modifierId);
    }
}
