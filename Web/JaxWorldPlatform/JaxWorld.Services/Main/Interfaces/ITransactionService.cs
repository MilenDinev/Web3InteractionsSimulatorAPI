﻿namespace JaxWorld.Services.Main.Interfaces
{
    using Data.Entities.Transactions;
    using Models.Requests.BlockchainRequests.TransactionModels;

    public interface ITransactionService
    {
        Task<Transaction> CreateAsync(CreateTransactionModel model, int targetContractId);
        Task UpdateStateAsync(Transaction transaction, int state, int modifierId);
    }
}
