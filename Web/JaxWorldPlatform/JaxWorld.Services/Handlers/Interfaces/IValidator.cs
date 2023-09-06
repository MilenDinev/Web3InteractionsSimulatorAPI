namespace JaxWorld.Services.Handlers.Interfaces
{
    using Data.Entities;
    using Data.Entities.Wallets;
    using Data.Interfaces.IEntities;

    public interface IValidator
    {
        Task ValidateTargetEntityAvailabilityAsync<T>(T entity) where T : class, IEntity;
        Task ValidateUniqueEntityAsync<T>(T entity) where T : class, IEntity;
        Task ValidateWalletOwnershipAsync(User Owner, Wallet wallet);
        Task ValidateContractOwnershipAsync(Wallet wallet, int contraId);
    }
}
