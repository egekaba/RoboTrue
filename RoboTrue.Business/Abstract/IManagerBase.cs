using RoboTrue.Core.Entities;
using System.Linq.Expressions;

namespace RoboTrue.Business.Abstract
{
    public interface IManagerBase<T> where T : BaseEntity
    {
        Task<int> Insert(T entity);
        Task<int> Update(T entity);
        Task<int> Delete(T entity);
        Task<T> GetById(int id);
        Task<ICollection<T>> GetAll(Expression<Func<T, bool>>? filter);
        Task<IQueryable<T>>? GetAllInclude(Expression<Func<T, bool>>? filter = null, params Expression<Func<T, object>>[]? include);
    }
}
