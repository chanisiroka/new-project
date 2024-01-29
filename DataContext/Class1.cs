
using Microsoft.EntityFrameworkCore;
using MyProject.Repository.Entity;
using MyProject.Repository.Interfaces;


namespace DataContext
{
    public class DataContext1 : DbContext, IContext
    {
        public DbSet<Claim> Claims { get ; set ; }
        public DbSet<Role> Roles { get ; set ; }
        public DbSet<Permission> Permissions { get ; set ; }

        public async Task save()
        {
           await SaveChangesAsync();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=mydb;trusted_connection=true;");
        }



    }
}