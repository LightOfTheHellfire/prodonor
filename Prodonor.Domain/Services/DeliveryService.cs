using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Prodonor.Domain.Model;
using Prodonor.Domain.RepositoryInterfaces;

namespace Prodonor.Domain.Services
{
    public class DeliveryService : IDomainService<Delivery>
    {
        private readonly IRepository<Delivery> _repository;

        public DeliveryService(IRepository<Delivery> repository)
        {
            _repository = repository;
        }

        public async Task<Delivery> CreateAsync(Delivery entity)
        {
            return await _repository.Add(entity);
        }

        public async Task UpdateAsync(Delivery entity)
        {
            await _repository.SetModified(entity);
        }

        public async Task<Delivery> GetAsync(int id)
        {
            return await _repository.GetAsync(id);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<IEnumerable<Delivery>> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
