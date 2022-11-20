using Microsoft.EntityFrameworkCore;
namespace CrudOperation.Models
{
    public class EmployeeDBcontext:DbContext
    {
        public EmployeeDBcontext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Employee>? Employees { get; set; }
    }
}
