namespace JaxWorld.Services.Handlers
{
    using Microsoft.EntityFrameworkCore;
    using Interfaces;
    using Data;
    using Data.Interfaces.IEntities;

    public class Finder : IFinder
    {
        private readonly JaxWorldDbContext dbContext;

        public Finder(JaxWorldDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<T> FindByIdOrDefaultAsync<T>(int id) where T : class, IEntity
        {
            var entity = await this.dbContext.Set<T>().FirstOrDefaultAsync(e => e.Id == id);
            return entity;
        }
        public async Task<T> FindByStringOrDefaultAsync<T>(string stringValue) where T : class, IEntity
        {
            var entity = await this.dbContext.Set<T>().FirstOrDefaultAsync(e => e.NormalizedTag == stringValue.ToUpper());
            return entity;
        }

        public async Task<ICollection<T>> GetAllAsync<T>() where T : class, IEntity
        {
            var entities = await this.dbContext.Set<T>().ToArrayAsync();

            return entities;
        }
        public async Task<ICollection<T>> GetAllActiveAsync<T>() where T : class, IEntity
        {
            var entities = await GetAllAsync<T>();

            return entities.Where(s => !s.Deleted).ToList();
        }
    }
}
