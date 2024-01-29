
using MyProject.Repository.Entity;
using MyProject.Repository.Interfaces;
using System.Collections.Generic;

namespace Mock
{
    public class MockContext : IContext
    {
        public List<Role> Roles { get; set; }
        public List<Claim> Claims { get; set; }
        public List<Permission> Permissions { get; set; }
        public MockContext()
        {
           // this.Roles = new List<Role>();
            //this.Permissions = new List<Permission>();
           // this.Claims = new List<Claim>();

            this.Roles.Add(new Role { Id = 1, Name = "admin", Description = "administrator with full access" });
            this.Roles.Add(new Role { Id = 2, Name = "user", Description = "user with limited access" });

            this.Permissions.Add(new Permission { Id = 1, Name = "VIEW_ALL_ORDERS" });
            this.Permissions.Add(new Permission { Id = 2, Name = "VIEW_ALL_PRODUCTS" });

            this.Claims.Add(new Claim { Id = 1, IdRole = 1, IdPermission = 1, Policy = ePolicy.Allow });
            this.Claims.Add(new Claim { Id = 2, IdRole = 2, IdPermission = 1, Policy = ePolicy.Deny });
            this.Claims.Add(new Claim { Id = 3, IdRole = 1, IdPermission = 2, Policy = ePolicy.Allow });
            this.Claims.Add(new Claim { Id = 4, IdRole = 2, IdPermission = 2, Policy = ePolicy.Allow });

        }

        public void save()
        {
          
        }
    }
}