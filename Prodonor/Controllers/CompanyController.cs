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
    [Route("company")]
    public class CompanyController : BaseController
    {
        private IApplicationService<CompanyDto> _service;

        public CompanyController(IApplicationService<CompanyDto> service)
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
        public async Task<IActionResult> Update([FromBody]CompanyDto Company)
        {
            return await ExecForResult(() => _service.UpdateAsync(Company));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return await ExecForResult(() => _service.DeleteAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody]CompanyDto obj)
        {
            var userId = User.GetUserId();
            return await ExecForResult(() => _service.CreateAsync(obj, userId));
        }
    }
}
