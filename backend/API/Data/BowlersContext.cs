using API.Data;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class BowlersContext : DbContext
    {
        public BowlersContext(DbContextOptions<BowlersContext> options) : base(options) { }

        public DbSet<Bowlers> Bowlers { get; set; }
        public DbSet<Teams> Teams { get; set; } // Include the Teams entity set
    }
}
