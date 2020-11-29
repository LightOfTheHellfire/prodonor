using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Prodonor.Application.Model;
using Prodonor.Domain.Model;
using Prodonor.Domain.Services;

namespace Prodonor.Application.Services
{
    public class OrderAppService : IApplicationService<OrderDto>
    {
        private readonly IDomainService<Order> _service;
        private IMapper _mapper;

        public OrderAppService(IMapper mapper, IDomainService<Order> service)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<OrderDto> CreateAsync(OrderDto entity, int? userId)
        {
            var domainEntity = _mapper.Map<OrderDto, Order>(entity);
            var result = await _service.CreateAsync(domainEntity);
            return _mapper.Map<Order, OrderDto>(result);
        }

        public async Task UpdateAsync(OrderDto entity)
        {
            var domainEntity = _mapper.Map<OrderDto, Order>(entity);
            await _service.UpdateAsync(domainEntity);
        }

        public async Task<OrderDto> GetAsync(int id)
        {
            var result = await _service.GetAsync(id);
            return _mapper.Map<Order, OrderDto>(result);
        }

        public async Task DeleteAsync(int id)
        {
            await _service.DeleteAsync(id);
        }

        public async Task<IEnumerable<OrderDto>> GetAll()
        {
            var result = await _service.GetAll();
            return _mapper.Map<IEnumerable<Order>, IEnumerable<OrderDto>>(result);
        }
    }
}
