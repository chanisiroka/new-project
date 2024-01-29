using MyProject.Common.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Service.Interfaces
{
    //bll
    public interface IService<T>
    {
        public Task<List<T>> getAllAsync();
        public Task<T> getAsync(int id);
        public Task updateAsync(int id,T entity);
        public Task deleteAsync(int id);
        public Task AddAsync(T entity);
    }
}
