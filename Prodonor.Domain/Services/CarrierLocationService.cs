using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Prodonor.Domain.Model;
using Prodonor.Domain.RepositoryInterfaces;

namespace Prodonor.Domain.Services
{
    public class CarrierLocationService : IDomainService<CarrierLocation>
    {
        private readonly IRepository<CarrierLocation> _repository;

        public CarrierLocationService(IRepository<CarrierLocation> repository)
        {
            _repository = repository;
        }

        public async Task<CarrierLocation> CreateAsync(CarrierLocation entity)
        {
            return await _repository.Add(entity);
        }

        public async Task UpdateAsync(CarrierLocation entity)
        {
            await _repository.SetModified(entity);
        }

        public async Task<CarrierLocation> GetAsync(int id)
        {
            return await _repository.GetAsync(id);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<IEnumerable<CarrierLocation>> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
