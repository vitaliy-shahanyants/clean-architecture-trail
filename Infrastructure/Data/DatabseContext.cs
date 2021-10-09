using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class DatabaseContext: DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DatabaseContext(DbContextOptions <DatabaseContext> options):base(options)
        {
            
        }
    }
}