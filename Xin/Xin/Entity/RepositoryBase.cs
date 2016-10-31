using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xin.Entity
{
    public class RepositoryBase<TEntity, TPrimaryKey> : IRepository<TEntity, TPrimaryKey>, IRepository, ITransientDependency where TEntity : class, IEntity<TPrimaryKey>
    {
        protected RepositoryBase();


        public int Count()
        {
            throw new NotImplementedException();
        }

        public int Count(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Delete(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TPrimaryKey id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(TPrimaryKey id)
        {
            throw new NotImplementedException();
        }

        public TEntity FirstOrDefault(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public TEntity FirstOrDefault(TPrimaryKey id)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> FirstOrDefaultAsync(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> FirstOrDefaultAsync(TPrimaryKey id)
        {
            throw new NotImplementedException();
        }

        public TEntity Get(TPrimaryKey id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetAllIncluding(params System.Linq.Expressions.Expression<Func<TEntity, object>>[] propertySelectors)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetAllList()
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetAllList(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> GetAllListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> GetAllListAsync(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetAsync(TPrimaryKey id)
        {
            throw new NotImplementedException();
        }

        public TEntity Insert(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TPrimaryKey InsertAndGetId(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<TPrimaryKey> InsertAndGetIdAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> InsertAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity InsertOrUpdate(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TPrimaryKey InsertOrUpdateAndGetId(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<TPrimaryKey> InsertOrUpdateAndGetIdAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> InsertOrUpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity Load(TPrimaryKey id)
        {
            throw new NotImplementedException();
        }

        public long LongCount()
        {
            throw new NotImplementedException();
        }

        public long LongCount(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<long> LongCountAsync()
        {
            throw new NotImplementedException();
        }

        public Task<long> LongCountAsync(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public T Query<T>(Func<IQueryable<TEntity>, T> queryMethod)
        {
            throw new NotImplementedException();
        }

        public TEntity Single(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> SingleAsync(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public TEntity Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity Update(TPrimaryKey id, Action<TEntity> updateAction)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> UpdateAsync(TPrimaryKey id, Func<TEntity, Task> updateAction)
        {
            throw new NotImplementedException();
        }
    }
}
