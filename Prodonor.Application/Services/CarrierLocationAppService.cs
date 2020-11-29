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
    public class CarrierLocationAppService : IApplicationService<CarrierLocationDto>
    {
        private readonly IDomainService<CarrierLocation> _service;
        private IMapper _mapper;

        public CarrierLocationAppService(IMapper mapper, IDomainService<CarrierLocation> service)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<CarrierLocationDto> CreateAsync(CarrierLocationDto entity, int? userId)
        {
            var domainEntity = _mapper.Map<CarrierLocationDto, CarrierLocation>(entity);
            var result = await _service.CreateAsync(domainEntity);
            return _mapper.Map<CarrierLocation, CarrierLocationDto>(result);
        }

        public async Task UpdateAsync(CarrierLocationDto entity)
        {
            var domainEntity = _mapper.Map<CarrierLocationDto, CarrierLocation>(entity);
            await _service.UpdateAsync(domainEntity);
        }

        public async Task<CarrierLocationDto> GetAsync(int id)
        {
            var result = await _service.GetAsync(id);
            return _mapper.Map<CarrierLocation, CarrierLocationDto>(result);
        }

        public async Task DeleteAsync(int id)
        {
            await _service.DeleteAsync(id);
        }

        public async Task<IEnumerable<CarrierLocationDto>> GetAll()
        {
            var result = await _service.GetAll();
            return _mapper.Map<IEnumerable<CarrierLocation>, IEnumerable<CarrierLocationDto>>(result);
        }
    }
}
