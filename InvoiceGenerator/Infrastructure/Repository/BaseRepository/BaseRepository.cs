using InvoiceGenerator.InvoiceData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace InvoiceGenerator.Infrastructure.Repository.BaseRepository
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity>
    where TEntity : class, new()
    {
        protected readonly InvocieContex DbContext;

        public BaseRepository(InvocieContex dbContext)
        {
            DbContext = dbContext;
        }

        public virtual async Task<TEntity?> GetByIdAsync<T>(T id)
        {
            return await DbContext.Set<TEntity>()
                .FindAsync(id)
                .ConfigureAwait(false);
        }

        public Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public virtual async Task<TEntity> CreateAsync(TEntity entity)
        {
            try
            {
                var dbEntity = await DbContext.Set<TEntity>().AddAsync(entity);
                await DbContext.SaveChangesAsync();
                return dbEntity.Entity;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
          
        }

        public Task UpdateAsync(int id, TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
