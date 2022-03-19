using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AB_AracIhaleCore.DAL.EntitiyFramework.Abstract
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(object id);
        List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);
        int Add(TEntity entity);
        int Update(TEntity entity);
        int Delete(TEntity entity);
    }
}
