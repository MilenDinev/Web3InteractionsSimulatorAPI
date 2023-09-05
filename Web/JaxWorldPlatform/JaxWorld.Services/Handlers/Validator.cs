namespace JaxWorld.Services.Handlers
{
    using Constants;
    using Exceptions;
    using Interfaces;
    using Data.Entities;
    using Data.Entities.Wallets;
    using Data.Interfaces.IEntities;

    public class Validator : IValidator
    {
        private readonly IEntityChecker entityChecker;

        public Validator(IEntityChecker entityChecker)
        {
            this.entityChecker = entityChecker;
        }

        public async Task ValidateEntityAsync<T>(T entity) where T : class, IEntity
        {
            string entityType = typeof(T).Name;

            if (await entityChecker.NullableCheck(entity))
                throw new ResourceNotFoundException(string.Format(ErrorMessages.EntityDoesNotExist, entityType));

            if (await entityChecker.DeletedCheck(entity))
                throw new ResourceNotFoundException(string.Format(ErrorMessages.EntityHasBeenDeleted, entityType));
        }

        public async Task ValidateUniqueEntityAsync<T>(T entity) where T : class, IEntity
        {
            var entityType = typeof(T).Name;

            if (await Task.Run(() => entity != null))
                throw new ResourceAlreadyExistsException(string.Format(ErrorMessages.EntityAlreadyContained, entityType));
        }

        public async Task ValidateWalletOwnershipAsync(User owner, Wallet wallet)
        {
            var entityType = typeof(User).Name;

            if (await Task.Run(() => !owner.Wallets.Contains(wallet)))
                throw new ResourceAlreadyExistsException(string.Format(ErrorMessages.UserDoesNotOwnWallet, entityType, wallet.Address));
        }

        public async Task ValidateProfileOwnershipAsync(Wallet wallet, int contraId)
        {
            var entityType = typeof(Wallet).Name;
            

            if (await Task.Run(() => !wallet.CreatedContracts.Select(x => x.Id).Any(y => y == contraId)))
                throw new ResourceAlreadyExistsException(string.Format(ErrorMessages.WalletDoesNotHaveRightsToMint, entityType, contraId));
        }
    }
}
