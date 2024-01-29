using Microsoft.EntityFrameworkCore;
using MyProject.Repository.Entity;
using MyProject.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repository.Repositories
{
    public class RoleRepository : IRepository<Role>
    {
        private readonly IContext _context;
        public RoleRepository(IContext context)
        {
            _context = context;
        }
        public async Task addItemAsync(Role item)
        {
          await  _context.Roles.AddAsync(item);
          await  _context.save();
        }

        public async Task deleteAsync(int id)
        {
            _context.Roles.Remove(await getAsync(id));
          await  _context.save();
        }

        public async Task<Role> getAsync(int id)
        {
            return await _context.Roles.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Role>> getAllAsync()
        {
           return await _context.Roles.ToListAsync();
        }

        public async Task updateAsync(int id, Role entity)
        {
            _context.Roles.Update(entity);
         await   _context.save();
        }
    }
}
