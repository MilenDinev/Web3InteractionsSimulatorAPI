using JaxWorld.Data.Interfaces.IEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaxWorld.Services.Handlers.Interfaces
{
    public interface IEntityChecker
    {
        Task<bool> NullableCheck<T>(T entity, string searchFlag) where T : class, IEntity;
        Task<bool> DeletedCheck<T>(T entity) where T : class, IEntity;
    }
}
