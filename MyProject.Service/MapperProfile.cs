using AutoMapper;
using MyProject.Common.Entity;
using MyProject.Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Service
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<RoleDto, Role>().ReverseMap();
            CreateMap<ClaimDto, Claim>().ReverseMap();
            CreateMap<PermissionDto, Permission>().ReverseMap();
        }
    }
}
