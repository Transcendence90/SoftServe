using Microsoft.EntityFrameworkCore;
using SportsBet247.Models;

namespace SportsBet247.Data
{
    public class SportsBet247DbContext : DbContext
    {
        public SportsBet247DbContext()
        {
        }

        public SportsBet247DbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<FootballEvent> FootballEvents { get; set; }

        public DbSet<BasketballEvent> BasketballEvents { get; set; }

        public DbSet<VolleyballEvent> VolleyballEvents { get; set; }

        public DbSet<TennisEvent> TennisEvents { get; set; }

        public DbSet<BoxingEvent> BoxingEvents { get; set; }

        public DbSet<MMAEvent> MMAEvents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=SportsBet247;Integrated Security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
