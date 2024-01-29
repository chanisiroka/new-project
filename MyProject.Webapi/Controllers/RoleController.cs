using Microsoft.AspNetCore.Mvc;
using MyProject.Common.Entity;
using MyProject.Service.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyProject.Webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IService<RoleDto> service;

        public RoleController(IService<RoleDto> service)
        {
            this.service = service; 
        }
       
        // GET: api/<RoleController>
        [HttpGet]
        public async Task< List<RoleDto>> Get()
        {
            return await service.getAllAsync();
        }

        // GET api/<RoleController>/5
        [HttpGet("{id}")]
        public async Task<RoleDto> Get(int id)
        {
            return  await service.getAsync(id);
        }

        // POST api/<RoleController>
        [HttpPost]
        public async Task Post([FromBody] RoleDto role)
        {
           await service.AddAsync(role);
        }

        // PUT api/<RoleController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] RoleDto r)
        {
           await service.updateAsync(id, r);
        }

        // DELETE api/<RoleController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
           await service.deleteAsync(id); 
        }
    }
}
