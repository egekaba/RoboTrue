using RoboTrue.Core.Entities;
using RoboTrue.DataAcsess.Repositories.Abstract;
using RoboTrue.DataAcsess.Repositories.Concrate;
using System.Linq.Expressions;

namespace RoboTrue.Business.Abstract
{
    public class KullaniciManagerBase<T> : IKullanicciManagerBase<T> where T : OlusturanKullanici, new()
    {
        private readonly IKullaniciBaseRepository<T> repository;

        public KullaniciManagerBase()
        {
            this.repository = new KullaniciBaseRepository<T>();
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
