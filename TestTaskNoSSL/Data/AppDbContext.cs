using Microsoft.EntityFrameworkCore;
using TestTaskNoSSL.Models;

namespace TestTaskNoSSL.Data
{
    public class AppDbContext:DbContext
    {
        public virtual DbSet<Dir> Dirs { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

    }
}
