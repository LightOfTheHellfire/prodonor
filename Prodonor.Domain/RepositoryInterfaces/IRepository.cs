using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodonor.Domain.RepositoryInterfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<TEntity> Add(TEntity entity);
        Task<TEntity> GetAsync(int id);
        TEntity Get(int id);
        void Remove(int id);
        Task RemoveAsync(int id);
        void RemoveRange(IEnumerable<TEntity> entities);
        Task SetModified(TEntity entity);
        IEnumerable<TEntity> GetAll();
        IQueryable<TEntity> GetAllQueryable();
    }
}
