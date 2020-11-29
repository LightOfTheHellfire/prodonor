using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Prodonor.Domain.Model;
using Prodonor.Domain.RepositoryInterfaces;

namespace Prodonor.Domain.Services
{
    public class OrderToProductService : IDomainService<OrderToProduct>
    {
        private readonly IRepository<OrderToProduct> _repository;

        public OrderToProductService(IRepository<OrderToProduct> repository)
        {
            _repository = repository;
        }

        public async Task<OrderToProduct> CreateAsync(OrderToProduct entity)
        {
            return await _repository.Add(entity);
        }

        public async Task UpdateAsync(OrderToProduct entity)
        {
            await _repository.SetModified(entity);
        }

        public async Task<OrderToProduct> GetAsync(int id)
        {
            return await _repository.GetAsync(id);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<IEnumerable<OrderToProduct>> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
