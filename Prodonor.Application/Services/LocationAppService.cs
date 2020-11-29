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
    public class LocationAppService : IApplicationService<LocationDto>
    {
        private readonly IDomainService<Location> _service;
        private IMapper _mapper;

        public LocationAppService(IMapper mapper, IDomainService<Location> service)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<LocationDto> CreateAsync(LocationDto entity, int? userId)
        {
            var domainEntity = _mapper.Map<LocationDto, Location>(entity);
            var result = await _service.CreateAsync(domainEntity);
            return _mapper.Map<Location, LocationDto>(result);
        }

        public async Task UpdateAsync(LocationDto entity)
        {
            var domainEntity = _mapper.Map<LocationDto, Location>(entity);
            await _service.UpdateAsync(domainEntity);
        }

        public async Task<LocationDto> GetAsync(int id)
        {
            var result = await _service.GetAsync(id);
            return _mapper.Map<Location, LocationDto>(result);
        }

        public async Task DeleteAsync(int id)
        {
            await _service.DeleteAsync(id);
        }

        public async Task<IEnumerable<LocationDto>> GetAll()
        {
            var result = await _service.GetAll();
            return _mapper.Map<IEnumerable<Location>, IEnumerable<LocationDto>>(result);
        }
    }
}
