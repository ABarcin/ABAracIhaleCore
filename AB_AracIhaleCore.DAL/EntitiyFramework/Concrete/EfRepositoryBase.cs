using AB_AracIhaleCore.DAL.EntitiyFramework.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace AB_AracIhaleCore.DAL.EntitiyFramework.Concrete
{
    public class EfRepositoryBase<TEntity, Tcontext> : IRepository<TEntity>
          where TEntity : class, new()
          where Tcontext : DbContext, new()
    {
        public int Add(TEntity entity)
        {
            using (var context = new Tcontext())
            {
                var added = context.Entry(entity);
                added.State = EntityState.Added;
                return context.SaveChanges();
            }
        }

        public int Delete(TEntity entity)
        {
            using (var context = new Tcontext())
            {
                var deleted = context.Entry(entity);
                deleted.State = EntityState.Deleted;
                return context.SaveChanges();
            }
        }

        public TEntity Get(object id)
        {
            using (var context = new Tcontext())
            {
                return context.Set<TEntity>().Find(id);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new Tcontext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public int Update(TEntity entity)
        {
            using (var context = new Tcontext())
            {
                var updated = context.Entry(entity);
                updated.State = EntityState.Modified;
                return context.SaveChanges();
            }
        }
    }
}
