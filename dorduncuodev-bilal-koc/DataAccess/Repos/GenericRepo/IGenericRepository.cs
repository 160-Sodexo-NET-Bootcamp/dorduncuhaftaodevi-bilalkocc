using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repos.GenericRepo
{
    public interface IGenericRepository<T> where T : class
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        void UpdateList(List<T> entities);
        IEnumerable<T> GetByExp(Expression<Func<T, bool>> expression);

    }
}
