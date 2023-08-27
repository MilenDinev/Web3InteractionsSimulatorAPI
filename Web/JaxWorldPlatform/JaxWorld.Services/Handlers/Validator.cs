namespace JaxWorld.Services.Handlers
{
    using Constants;
    using Exceptions;
    using Interfaces;
    using Data.Interfaces.IEntities;

    public class Validator : IValidator
    {
        private readonly IEntityChecker entityChecker;

        public Validator(IEntityChecker entityChecker)
        {
            this.entityChecker = entityChecker;
        }

        public async Task ValidateEntityAsync<T>(T entity, string flag) where T : class, IEntity
        {
            var entityType = typeof(T).ToString().Substring(typeof(T).ToString().LastIndexOf('.') + 1);
            var isNullable = await this.entityChecker.NullableCheck(entity, flag);
            if (isNullable)
                throw new ResourceNotFoundException(string.Format(ErrorMessages.EntityDoesNotExist, entityType));
            var isDeleted = await this.entityChecker.DeletedCheck(entity);
            if (isDeleted)
                throw new ResourceNotFoundException(string.Format(ErrorMessages.EntityHasBeenDeleted, entityType));
        }

        public async Task ValidateUniqueEntityAsync<T>(T entity) where T : class, IEntity
        {
            var entityType = typeof(T).ToString().Substring(typeof(T).ToString().LastIndexOf('.') + 1);
            if (await Task.Run(() => entity != null))
                throw new ResourceAlreadyExistsException(string.Format(ErrorMessages.EntityAlreadyContained, entityType));
        }
    }
}
