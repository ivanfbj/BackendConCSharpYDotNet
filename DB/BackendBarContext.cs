using Microsoft.EntityFrameworkCore;

namespace DB
{
    public class BackendBarContext : DbContext
    {
        public BackendBarContext(DbContextOptions<BackendBarContext> options) : 
            base(options)
        { }

        public DbSet<Beer> Beers { get; set; }
    }
}