using cinama.model;
using Microsoft.EntityFrameworkCore;

namespace cinama.Data
{
    public class AppDbcontext : DbContext
    {
        public AppDbcontext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Movies> Movies { get; set; }
        public DbSet <Category> Categories { get; set; }

        public DbSet<National> National { get; set; }
        public DbSet<Director> Directors { get; set; }
    }
}
