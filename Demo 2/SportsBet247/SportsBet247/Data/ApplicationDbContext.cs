using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SportsBet247.Models;

namespace SportsBet247.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<FootballEvent> FootballEvents { get; set; }

        public DbSet<BasketballEvent> BasketballEvents { get; set; }

        public DbSet<TennisEvent> TennisEvents { get; set; }

        public DbSet<BoxingEvent> BoxingEvents { get; set; }

        public DbSet<VolleyballEvent> VolleyballEvents { get; set; }

        public DbSet<MMAEvent> MMAEvents { get; set; }
    }
}
