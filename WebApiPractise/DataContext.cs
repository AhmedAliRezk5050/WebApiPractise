using Microsoft.EntityFrameworkCore;
using WebApiPractise.Models;

namespace WebApiPractise
{
    public class DataContext : DbContext
    {
        public DataContext(
              DbContextOptions<DataContext> opts) : base(opts)
        {
        }

        public DbSet<Employee> Employees { get; set; } = null!;
    }
}
