using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterClone.CORE.Entity.Core;
using TwitterClone.MODEL.Data;

namespace TwitterClone.MODEL.Repositories
{
    public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : CoreEntity
    {
        private readonly AppDbContext dbContext;

        public GenericRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task Create(TEntity entity)
        {
            await dbContext.Set<TEntity>().AddAsync(entity);
            await dbContext.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            var entity = await GetById(id);
            dbContext.Set<TEntity>().Remove(entity);
            await dbContext.SaveChangesAsync();
        }

        public IQueryable<TEntity> GetAll()
        {
            return dbContext.Set<TEntity>().AsNoTracking();
        }

        public async Task<TEntity> GetById(Guid id)
        {
            return await dbContext.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(p => p.ID.Equals(id));
        }

        public async Task Update(TEntity entity)
        {
            dbContext.Set<TEntity>().Update(entity);
            await dbContext.SaveChangesAsync();
        }
    }
}
