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
    public class StoreAppService : IApplicationService<StoreDto>
    {
        private readonly IDomainService<Store> _service;
        private IMapper _mapper;

        public StoreAppService(IMapper mapper, IDomainService<Store> service)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<StoreDto> CreateAsync(StoreDto entity, int? userId)
        {
            var domainEntity = _mapper.Map<StoreDto, Store>(entity);
            domainEntity.StoreRoles = new List<StoreRoles>();
            var storeRole = new StoreRoles();
            storeRole.RoleId = 1;
            storeRole.UserStoreRoles = new List<UserStoreRoles>() { new UserStoreRoles() { UserId = (int)userId } };
            domainEntity.StoreRoles.Add(storeRole);
            var result = await _service.CreateAsync(domainEntity);
            return _mapper.Map<Store, StoreDto>(result);
        }

        public async Task UpdateAsync(StoreDto entity)
        {
            var domainEntity = _mapper.Map<StoreDto, Store>(entity);
            await _service.UpdateAsync(domainEntity);
        }

        public async Task<StoreDto> GetAsync(int id)
        {
            var result = await _service.GetAsync(id);
            return _mapper.Map<Store, StoreDto>(result);
        }

        public async Task DeleteAsync(int id)
        {
            await _service.DeleteAsync(id);
        }

        public async Task<IEnumerable<StoreDto>> GetAll()
        {
            var result = await _service.GetAll();
            return _mapper.Map<IEnumerable<Store>, IEnumerable<StoreDto>>(result);
        }
    }
}
