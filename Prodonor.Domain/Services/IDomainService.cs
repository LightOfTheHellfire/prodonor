using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Prodonor.Domain.Services
{
    public interface IDomainService<TEntity>
    {
        Task<TEntity> CreateAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task<TEntity> GetAsync(int id);
        Task DeleteAsync(int id);
        //        Task<IQueryable<TEntity>> GetAll();
        Task<IEnumerable<TEntity>> GetAll();
    }
}
