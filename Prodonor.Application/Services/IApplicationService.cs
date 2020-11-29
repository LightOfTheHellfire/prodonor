using System.Collections.Generic;
using System.Threading.Tasks;

namespace Prodonor.Application.Services
{
    public interface IApplicationService<TEntity>
    {
        Task<TEntity> CreateAsync(TEntity entity, int? userId = null);
        Task UpdateAsync(TEntity entity);
        Task<TEntity> GetAsync(int id);
        Task DeleteAsync(int id);
        //        Task<IQueryable<TEntity>> GetAll();
        Task<IEnumerable<TEntity>> GetAll();
    }
}
