using Microsoft.Extensions.DependencyInjection;
using MyProject.Common.Entity;
using MyProject.Repository;
using MyProject.Service.Interfaces;
using MyProject.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Service
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services) 
        {
            services.AddRepositories();
            services.AddScoped<IService<RoleDto>, RoleService>();
            services.AddAutoMapper(typeof(MapperProfile));
            return services;
        }
    }
}
