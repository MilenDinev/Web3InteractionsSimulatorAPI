namespace JaxWorld.Services.Base
{
    using Interfaces;
    using Data;
    using Data.Interfaces.IEntities;
    using JaxWorld.Data.Entities;

    internal abstract class BaseService<TEntity> : IBaseService where TEntity : class, IEntity
    {
        internal readonly JaxWorldDbContext dbContext;

        internal BaseService(JaxWorldDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        internal async Task CreateEntityAsync(TEntity entity, int creatorId)
        {
            await AddEntityAsync(entity, creatorId);
            await SaveModificationAsync(entity, creatorId);
        }
        internal async Task DeleteEntityAsync(TEntity entity, int modifierId)
        {
            entity.Deleted = true;
            await SaveModificationAsync(entity, modifierId);
        }


        public async Task SaveModificationAsync(TEntity entity, int modifierId)
        {
            entity.LastModifierId = modifierId;
            entity.LastModifiedOn = DateTime.UtcNow;

            await dbContext.SaveChangesAsync();
        }
        private async Task AddEntityAsync(TEntity entity, int creatorId)
        {

            entity.CreatorId = creatorId;
            entity.CreatedOn = DateTime.UtcNow;
            await dbContext.AddAsync(entity);
        }
    }
}
