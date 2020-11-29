using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Prodonor.Domain.Model;
using Prodonor.Domain.RepositoryInterfaces;

namespace Prodonor.Domain.Services
{
    public class StoreService : IDomainService<Store>
    {
        private readonly IRepository<Store> _repository;

        public StoreService(IRepository<Store> repository)
        {
            _repository = repository;
        }

        public async Task<Store> CreateAsync(Store entity)
        {
            try
            {
                return await _repository.Add(entity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task UpdateAsync(Store entity)
        {
            await _repository.SetModified(entity);
        }

        public async Task<Store> GetAsync(int id)
        {
            return await _repository.GetAsync(id);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<IEnumerable<Store>> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
