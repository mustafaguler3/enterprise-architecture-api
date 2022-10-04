using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Core.Data.EntityFramework
{
    public class EntityRepository<T,TContext> : IEntityRepository<T> 
        where T :class
    {
        public void Add(T entity)
        {
            using (var context = new VtContext())
            {
                var addedEntity = context.Entry(entity);

                addedEntity.State = EntityState.Added;

                context.SaveChanges();
            }
        }

        public void Update(T entity)
        {
            using (var context = new VtContext())
            {
                var updateEntity = context.Entry(entity);

                updateEntity.State = EntityState.Modified;

                context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (var context = new VtContext())
            {
                var deletedEntity = context.Entry(entity);

                deletedEntity.State = EntityState.Deleted;

                context.SaveChanges();
            }
        }

        public List<T> GetAll()
        {
            using (var context = new VtContext())
            {
                return context.Set<T>().ToList();
            }
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            using (var context = new VtContext())
            {
                return context.Set<T>().Where(filter).SingleOrDefault();
            }
        }
    }
}
