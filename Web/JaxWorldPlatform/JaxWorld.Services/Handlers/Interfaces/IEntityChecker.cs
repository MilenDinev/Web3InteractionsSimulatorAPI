namespace JaxWorld.Services.Handlers.Interfaces
{
    using Data.Interfaces.IEntities;
    public interface IEntityChecker
    {
        Task<bool> NullableCheck<T>(T entity, string searchFlag) where T : class, IEntity;
        Task<bool> DeletedCheck<T>(T entity) where T : class, IEntity;
    }
}
