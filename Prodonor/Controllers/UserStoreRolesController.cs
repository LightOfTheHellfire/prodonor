using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Prodonor.Application.Model;
using Prodonor.Application.Services;
using Prodonor.Extensions;

namespace Prodonor.Controllers
{
    [Authorize]
    [ApiController]
    [Route("user-store-roles")]
    public class UserStoreRolesController : BaseController
    {
        private IApplicationService<UserStoreRolesDto> _service;

        public UserStoreRolesController(IApplicationService<UserStoreRolesDto> service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return await ExecForResult(() => _service.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return await ExecForResult(() => _service.GetAsync(id));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromBody]UserStoreRolesDto UserStoreRoles)
        {
            return await ExecForResult(() => _service.UpdateAsync(UserStoreRoles));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return await ExecForResult(() => _service.DeleteAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody]UserStoreRolesDto obj)
        {
            return await ExecForResult(() => _service.CreateAsync(obj));
        }
    }
}
