namespace JaxWorld.Services.Handlers
{
    using Interfaces;
    using Data;
    using Data.Interfaces.IEntities;

    public class EntityChecker : IEntityChecker
    {
        private readonly JaxWorldDbContext dbContext;

        public EntityChecker(JaxWorldDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<bool> NullableCheck<T>(T entity) where T : class, IEntity
        {
            return await Task.Run(() => entity == null);
        }

        public async Task<bool> DeletedCheck<T>(T entity) where T : class, IEntity
        {
            return await Task.Run(() => entity.Deleted);
        }
    }
}
