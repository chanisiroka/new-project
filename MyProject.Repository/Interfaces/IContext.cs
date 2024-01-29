
using Microsoft.EntityFrameworkCore;
using MyProject.Repository.Entity;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repository.Interfaces
{
    public interface IContext
    {
        public DbSet<Claim> Claims { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public Task save();
    }
}
