namespace JaxWorld.Services.Handlers.Interfaces
{
    using Data.Interfaces.IEntities;

    public interface IValidator
    {
        Task ValidateEntityAsync<T>(T entity, string flag) where T : class, IEntity;
        Task ValidateUniqueEntityAsync<T>(T entity) where T : class, IEntity;
    }
}
