
using Microsoft.Extensions.DependencyInjection;
using MyProject.Repository.Entity;
using MyProject.Repository.Interfaces;
using MyProject.Repository.Repositories;

namespace MyProject.Repository
{
    public static class ExtensionIserviceCollection
    {
        //מוסיפה את התלויות של השכבה
        public static IServiceCollection  AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IRepository<Role>, RoleRepository>();

            return services;
        }
    }
}
