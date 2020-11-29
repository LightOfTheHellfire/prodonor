using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Prodonor.Domain.Model;
using Prodonor.Domain.RepositoryInterfaces;

namespace Prodonor.Domain.Services
{
    public class OrderService : IDomainService<Order>
    {
        private readonly IRepository<Order> _repository;

        public OrderService(IRepository<Order> repository)
        {
            _repository = repository;
        }

        public async Task<Order> CreateAsync(Order entity)
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

        public async Task UpdateAsync(Order entity)
        {
            await _repository.SetModified(entity);
        }

        public async Task<Order> GetAsync(int id)
        {
            return await _repository.GetAsync(id);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<IEnumerable<Order>> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
