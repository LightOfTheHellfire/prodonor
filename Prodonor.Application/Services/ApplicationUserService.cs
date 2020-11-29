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
    public class ApplicationUserService
    {
        private UserService _service;
        private IMapper _mapper;

        public ApplicationUserService(IMapper mapper, UserService service)
        {
            _mapper = mapper;
            _service = service;
        }

        public async Task<UserDto> Authenticate(string username, string password)
        {
            return _mapper.Map<User, UserDto>(await _service.Authenticate(username, password));
        }

        public IEnumerable<User> GetAll()
        {
            return _service.GetAll();
        }

        public async Task<User> GetById(int id)
        {
            return await _service.GetById(id);
        }

        public async Task<User> Create(UserDto user, string password)
        {
            var entity = _mapper.Map<UserDto, User>(user);
            return await _service.Create(entity, password);
        }

        public async Task Update(UserDto userParam, string password = null)
        {
            var entity = _mapper.Map<UserDto, User>(userParam);
            await _service.Update(entity, password);
        }

        public async Task Delete(int id)
        {
            await _service.Delete(id);
        }
    }
}
