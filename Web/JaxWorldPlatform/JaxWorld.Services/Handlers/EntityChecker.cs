using JaxWorld.Data.Interfaces.IEntities;
using JaxWorld.Data;
using JaxWorld.Services.Handlers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaxWorld.Services.Handlers
{
    internal class EntityChecker : IEntityChecker
    {
        private readonly JaxWorldDbContext dbContext;

        public EntityChecker(JaxWorldDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<bool> NullableCheck<T>(T entity, string searchFlag) where T : class, IEntity
        {
            return await Task.Run(() => entity == null);
        }
        public async Task<bool> DeletedCheck<T>(T entity) where T : class, IEntity
        {
            return await Task.Run(() => entity.Deleted);
        }
    }
}
