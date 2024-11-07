using Microsoft.EntityFrameworkCore;
using SemanticKernelExample01.Models;

namespace SemanticKernelExample01.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Productos { get; set; }
    }
}
