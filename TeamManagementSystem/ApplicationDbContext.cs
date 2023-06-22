using Microsoft.EntityFrameworkCore;
using TeamManagement.Shared;

namespace TeamManagementSystem
{
    public class ApplicationDbContext : DbContext
    {
        // connection to DB - :base(...) constructor gets called with the new option
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        
        // DbSet - define an entity in the DB - Table with names "Player", "Team"
        //Player
        public virtual DbSet<Player>Player { get; set; }
        //Team
        public virtual DbSet<Team>Team { get; set; }

        
    }
}
