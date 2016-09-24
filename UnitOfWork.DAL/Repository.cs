using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork.DAL
{
    public class Repository<TEntity, TKey> : IRepository<TEntity, TKey> 
        where TEntity : class 
        where TKey : struct
    {
        protected readonly DbContext Context;
        public Repository(DbContext Context)
        {
            this.Context = Context;
        }
        public void Add(TEntity Entity)
        {
            Context.Set<TEntity>().Add(Entity);
        }

        public void AddRange(IEnumerable<TEntity> Entities)
        {
            Context.Set<TEntity>().AddRange(Entities);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> Predicate)
        {
            return Context.Set<TEntity>().Where(Predicate);
        }

        public TEntity Get(TKey Key)
        {
            return Context.Set<TEntity>().Find(Key);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Context.Set<TEntity>().ToList();
        }

        public void Remove(TEntity Entity)
        {
            Context.Set<TEntity>().Remove(Entity);
        }

        public void RemoveRange(IEnumerable<TEntity> Entities)
        {
            Context.Set<TEntity>().RemoveRange(Entities);
        }
    }
}
