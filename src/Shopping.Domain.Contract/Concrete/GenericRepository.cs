using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Shopping.Domain.Contract.Abstract;
using Shopping.Domain.Contract.DataContext;
using Shopping.Domain.Entities.Entities;

namespace Shopping.Domain.Contract.Concrete
{

    public class GenericRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        internal ShoppingDataContext context;
        internal DbSet<TEntity> dbSet;

        public GenericRepository(ShoppingDataContext context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }

        public virtual IEnumerable<TEntity> GetAll(int page = 0, int pagesize = 0, bool asNoTracking = false,
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (orderBy != null)
            {
                query = orderBy(query);
            }
            
            
            
            if (page != 0 && pagesize != 0)
            {
                query = query.Skip(((page - 1) * pagesize)).Take(pagesize);
            }

            
            if (includes != null && includes.Any())
                foreach (var item in includes)
                    query = query.Include(item);

            if(asNoTracking)
            {
                query = query.AsNoTracking();
            }

            return query.ToList();
          
        }

        public virtual TEntity GetByID(object id)
        {
            return dbSet.Find(id);
        }

        public virtual TEntity Insert(TEntity entity)
        {
           return  dbSet.Add(entity);
        }

        public virtual void Delete(object id)
        {
            TEntity entityToDelete = dbSet.Find(id);
            Delete(entityToDelete);
        }

        public virtual void Delete(TEntity entityToDelete)
        {
            if (context.Entry(entityToDelete).State == EntityState.Detached)
            {
                dbSet.Attach(entityToDelete);
            }
            dbSet.Remove(entityToDelete);
        }

        public virtual void Update(TEntity entityToUpdate)
        {
            dbSet.Attach(entityToUpdate);
            context.Entry(entityToUpdate).State = EntityState.Modified;
        }


        public virtual void SaveChanges()
        {
            context.SaveChanges();
        }

         
    }
}
