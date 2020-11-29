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
    public class CarrierAppService : IApplicationService<CarrierDto>
    {
        private readonly IDomainService<Carrier> _service;
        private IMapper _mapper;

        public CarrierAppService(IMapper mapper, IDomainService<Carrier> service)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<CarrierDto> CreateAsync(CarrierDto entity, int? userId)
        {
            var domainEntity = _mapper.Map<CarrierDto, Carrier>(entity);
            var result = await _service.CreateAsync(domainEntity);
            return _mapper.Map<Carrier, CarrierDto>(result);
        }

        public async Task UpdateAsync(CarrierDto entity)
        {
            var domainEntity = _mapper.Map<CarrierDto, Carrier>(entity);
            await _service.UpdateAsync(domainEntity);
        }

        public async Task<CarrierDto> GetAsync(int id)
        {
            var result = await _service.GetAsync(id);
            return _mapper.Map<Carrier, CarrierDto>(result);
        }

        public async Task DeleteAsync(int id)
        {
            await _service.DeleteAsync(id);
        }

        public async Task<IEnumerable<CarrierDto>> GetAll()
        {
            var result = await _service.GetAll();
            return _mapper.Map<IEnumerable<Carrier>, IEnumerable<CarrierDto>>(result);
        }
    }
}
