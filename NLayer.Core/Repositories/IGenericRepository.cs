using System.Linq.Expressions;

namespace NLayer.Core.Repositories
{
    public interface IGenericRepository<T> where T : class 
    {
        Task<T> GetByIdAsync(int id);
        IQueryable<T> GetAll(Expression<Func<T, bool>> expression);
        // IQueryable yazmış olduğumuz sorgular direk veritabanına gitmez tolist vb. kullandığımızda veritabanına gider.Daha performanslı çalışır.
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        IQueryable<T> AnyAsync(Expression<Func<T, bool>> expression);
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        void Update(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);







    }
    

     
    
}
