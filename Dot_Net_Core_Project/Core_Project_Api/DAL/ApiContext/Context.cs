using Core_Project_Api.DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace Core_Project_Api.DAL.ApiContext
{
    public class Context : DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder
            optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-33VDDOP\\SQLEXPRESS17;database=APICoreProjeDB;integrated security=true");
        }
        public DbSet<Category>Categories { get; set; }
    }
}
