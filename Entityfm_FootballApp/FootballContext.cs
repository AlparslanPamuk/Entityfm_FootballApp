using System.Data.Entity;

namespace Entityfm_FootballApp
{
    public class FootballContext : DbContext
    {
        public DbSet<Team> Teams { get; set; }

        public DbSet<Player> Players { get; set; }

        public DbSet<Sponsor> Sponsors { get; set; }

        public DbSet<PlayerAddress> Addresses { get; set; }

        public FootballContext():base("FootballConStr")
        {

        }
    }
}
