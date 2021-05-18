using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterClone.CORE.Entity.Core;

namespace TwitterClone.MODEL.Repositories
{
    public interface IRepository<TEntity> where TEntity : CoreEntity
    {
        IQueryable<TEntity> GetAll();
        Task<TEntity> GetById(Guid id);
        Task Create(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(Guid id);
    }
}
