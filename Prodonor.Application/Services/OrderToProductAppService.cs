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
    public class OrderToProductAppService : IApplicationService<OrderToProductDto>
    {
        private readonly IDomainService<OrderToProduct> _service;
        private IMapper _mapper;

        public OrderToProductAppService(IMapper mapper, IDomainService<OrderToProduct> service)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<OrderToProductDto> CreateAsync(OrderToProductDto entity, int? userId)
        {
            var domainEntity = _mapper.Map<OrderToProductDto, OrderToProduct>(entity);
            var result = await _service.CreateAsync(domainEntity);
            return _mapper.Map<OrderToProduct, OrderToProductDto>(result);
        }

        public async Task UpdateAsync(OrderToProductDto entity)
        {
            var domainEntity = _mapper.Map<OrderToProductDto, OrderToProduct>(entity);
            await _service.UpdateAsync(domainEntity);
        }

        public async Task<OrderToProductDto> GetAsync(int id)
        {
            var result = await _service.GetAsync(id);
            return _mapper.Map<OrderToProduct, OrderToProductDto>(result);
        }

        public async Task DeleteAsync(int id)
        {
            await _service.DeleteAsync(id);
        }

        public async Task<IEnumerable<OrderToProductDto>> GetAll()
        {
            var result = await _service.GetAll();
            return _mapper.Map<IEnumerable<OrderToProduct>, IEnumerable<OrderToProductDto>>(result);
        }
    }
}
