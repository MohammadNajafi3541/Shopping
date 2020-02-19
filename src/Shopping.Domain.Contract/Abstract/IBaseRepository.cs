using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Shopping.Domain.Entities.Entities;

namespace Shopping.Domain.Contract.Abstract
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll(int page = 0, int pagesize = 0, bool asNoTracking = false,
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            params Expression<Func<TEntity, object>>[] includes);
        TEntity GetByID(object id);
        TEntity Insert(TEntity entity);
        void Update(TEntity entityToUpdate);
        void Delete(object id);
        void Delete(TEntity entityToDelete);
        void SaveChanges();
    }
}
