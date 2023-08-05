namespace JaxWorld.Services.Base
{
    using Interfaces;
    using Data;
    using Data.Interfaces.IEntities;

    public abstract class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class, IEntity
    {
        protected readonly JaxWorldDbContext dbContext;

        protected BaseService(JaxWorldDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        protected async Task CreateEntityAsync(TEntity entity, int creatorId)
        {
            await AddEntityAsync(entity, creatorId);
            await SaveModificationAsync(entity, creatorId);
        }
        protected async Task DeleteEntityAsync(TEntity entity, int modifierId)
        {
            entity.Deleted = true;
            await SaveModificationAsync(entity, modifierId);
        }


        public async Task SaveModificationAsync(TEntity entity, int modifierId)
        {
            entity.LastModifierId = modifierId;
            entity.LastModificationDate = DateTime.UtcNow;

            await dbContext.SaveChangesAsync();
        }
        private async Task AddEntityAsync(TEntity entity, int creatorId)
        {

            entity.CreatorId = creatorId;
            entity.CreationDate = DateTime.UtcNow;
            await dbContext.AddAsync(entity);
        }
    }
}
