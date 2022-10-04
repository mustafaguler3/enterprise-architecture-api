using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data
{
    public interface IEntityRepository<T> where T : class 
    {
        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        List<T> GetAll();

        T Get(Expression<Func<T,bool>> filter);
    }
}
