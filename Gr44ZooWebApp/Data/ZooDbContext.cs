using Gr44ZooWebApp.Models;
using Microsoft.EntityFrameworkCore;
namespace Gr44ZooWebApp.Data
    
{
    public class ZooDbContext:DbContext
    {
        public ZooDbContext(DbContextOptions<ZooDbContext> options) : base(options)
        { }
        public DbSet<Animal>? Animals { get; set; }
    }
}
