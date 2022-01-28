using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repos.GenericRepo
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DataContext context;
        internal DbSet<T> dbSet;

        public GenericRepository(DataContext context)
        {
            this.context = context;
            dbSet = context.Set<T>();
        }
        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            dbSet.Remove(entity);
        }

        public void Update(T entity)
        {
            dbSet.Update(entity);
        }

        public void UpdateList(List<T> entities)
        {
            dbSet.UpdateRange(entities);
        }

        public IEnumerable<T> GetByExp(Expression<Func<T, bool>> expression)
        {
            return dbSet.Where(expression).ToList();
        }
    }
}
