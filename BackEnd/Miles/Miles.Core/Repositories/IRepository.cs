using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Core.Repositories
{
    public interface IRepository<T> where T : class
    {
        public Task AddAsync(T entity);
        public Task Update(T entity);
        public Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>> expression, int count, int page, params string[] includes);
        public Task<T> GetAsync(Expression<Func<T, bool>> expression, params string[] includes);
        public Task<int> SaveAsync();
        public int Save();
        public Task<bool> isExsist(Expression<Func<T, bool>> expression);
    }
}
