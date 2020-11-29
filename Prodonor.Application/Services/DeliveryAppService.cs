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
    public class DeliveryAppService : IApplicationService<DeliveryDto>
    {
        private readonly IDomainService<Delivery> _service;
        private IMapper _mapper;

        public DeliveryAppService(IMapper mapper, IDomainService<Delivery> service)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<DeliveryDto> CreateAsync(DeliveryDto entity, int? userId)
        {
            var domainEntity = _mapper.Map<DeliveryDto, Delivery>(entity);
            var result = await _service.CreateAsync(domainEntity);
            return _mapper.Map<Delivery, DeliveryDto>(result);
        }

        public async Task UpdateAsync(DeliveryDto entity)
        {
            var domainEntity = _mapper.Map<DeliveryDto, Delivery>(entity);
            await _service.UpdateAsync(domainEntity);
        }

        public async Task<DeliveryDto> GetAsync(int id)
        {
            var result = await _service.GetAsync(id);
            return _mapper.Map<Delivery, DeliveryDto>(result);
        }

        public async Task DeleteAsync(int id)
        {
            await _service.DeleteAsync(id);
        }

        public async Task<IEnumerable<DeliveryDto>> GetAll()
        {
            var result = await _service.GetAll();
            return _mapper.Map<IEnumerable<Delivery>, IEnumerable<DeliveryDto>>(result);
        }
    }
}
