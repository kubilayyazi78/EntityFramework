using System.Data.Entity;

namespace FootballApplication
{
    public class FootballContext:DbContext
    {
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<PlayerAddress> PlayerAddresses { get; set; }
        public DbSet<Sponsor> Sponsors { get; set; }
        public FootballContext():base("FootballDbConStr")
        {
                
        }
    }
}
