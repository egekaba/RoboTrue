using RoboTrue.Business.Abstract;
using RoboTrue.Core.Entities;
using RoboTrue.DataAcsess.Repositories.Abstract;
using RoboTrue.DataAcsess.Repositories.Concrate;
using System.Linq.Expressions;

namespace RoboTrue.Business.Concrate
{
    public class ManagerBase<T> : IManagerBase<T> where T : BaseEntity, new()
    {

        private readonly IBaseRepository<T> repository;

        public ManagerBase()
        {
            this.repository = new BaseRepository<T>();
        }

        public async Task<int> Delete(T entity)
        {
            return await repository.Delete(entity);
        }

        public async Task<ICollection<T>> GetAll(Expression<Func<T, bool>>? filter)
        {
            return await repository.GetAll(filter);
        }

        public async Task<IQueryable<T>>? GetAllInclude(Expression<Func<T, bool>>? filter = null, params Expression<Func<T, object>>[]? include)
        {
            return await repository.GetAllInclude(filter, include);
        }

        public async Task<T> GetById(int id)
        {
            return await repository.GetById(id);
        }

        public async Task<int> Insert(T entity)
        {
            return await repository.Insert(entity);
        }

        public async Task<int> Update(T entity)
        {
            return await repository.Update(entity);
        }
    }
}
