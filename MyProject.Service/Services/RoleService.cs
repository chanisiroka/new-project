using AutoMapper;
using MyProject.Common.Entity;
using MyProject.Repository.Entity;
using MyProject.Repository.Interfaces;
using MyProject.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Service.Services
{
    public class RoleService : IService<RoleDto>
    {
      //המרה ממחלקה
        private readonly IMapper mapper;
        private readonly IRepository<Role> repository;
        public RoleService(IRepository<Role> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task AddAsync(RoleDto entity)
        {
           await repository.addItemAsync(mapper.Map<Role>(entity));
        }

        public async Task deleteAsync(int id)
        {
          await  repository.deleteAsync(id);
        }

        public async Task<RoleDto> getAsync(int id)
        {
            return  mapper.Map<RoleDto>(await repository.getAsync(id));
        }

        public async Task<List<RoleDto>> getAllAsync()
        {
           return  mapper.Map<List<RoleDto>>(await repository.getAllAsync());
        }

        public async Task updateAsync(int id, RoleDto entity)
        {
          await  repository.updateAsync(id,mapper.Map<Role>(entity));
        }
    }
}
