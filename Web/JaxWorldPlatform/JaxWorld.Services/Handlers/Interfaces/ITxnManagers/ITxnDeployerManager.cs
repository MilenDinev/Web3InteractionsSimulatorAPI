namespace JaxWorld.Services.Handlers.Interfaces.ITxnManagers
{
    using Data.Entities.Wallets;
    using Data.Entities.Contracts;
    using Data.Entities.Transactions;
    using Models.Requests.BlockchainRequests.TransactionModels;

    public interface ITxnDeployerManager
    {
        Task<CreateTransactionModel> GetCreateTxnModelAsync(string state,
        string action,
        int networkId,
        int creatorId,
        int initWalletId,
        long gasUsed,
        int? targetId = null);

        Task<Transaction> CreateTxnAsync(CreateTransactionModel createTxnModel, int? targetContract = null);

        Task UpdateTxnStateAsync(Transaction transaction, string state, int userId);

        Task<Contract> GetProfileContractAsync(Wallet wallet, int profileId);
    }
}
