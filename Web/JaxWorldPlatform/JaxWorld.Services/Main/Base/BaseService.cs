namespace JaxWorld.Services.Main.Base
{
    using Data;
    using Data.Interfaces.IEntities;

    public abstract class BaseService<TEntity> where TEntity : class, IEntity
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

        private async Task AddEntityAsync(TEntity entity, int creatorId)
        {
            entity.CreatorId = creatorId;
            entity.CreationDate = DateTime.UtcNow;

            await dbContext.AddAsync(entity);
        }

        protected async Task SaveModificationAsync(TEntity entity, int modifierId)
        {
            entity.LastModifierId = modifierId;
            entity.LastModificationDate = DateTime.UtcNow;

            await dbContext.SaveChangesAsync();
        }

    }
}
//[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]