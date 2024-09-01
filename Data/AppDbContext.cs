using Microsoft.EntityFrameworkCore;
using mvcOne.Models;


namespace mvcOne.Data
{
    public class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EmployeeMangmentSystem;Trusted_Connection=True;TrustServerCertificate=True;");

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
