using RoboTrue.Core.Entities;
using System.Linq.Expressions;

namespace RoboTrue.DataAcsess.Repositories.Abstract
{
    public interface IDepartmanBaseRepository<T> where T : Departman, new()
    {
        Task<int> Insert(T input);
        Task<int> Update(T input);
        Task<int> Delete(T input);

        Task<T?> GetById(int id);

        Task<ICollection<T>>? GetAll(Expression<Func<T, bool>>? filter = null);

        Task<IQueryable<T>>? GetAllInclude(Expression<Func<T, bool>>? filter = null, params Expression<Func<T, object>>[]? include);

    }
}
