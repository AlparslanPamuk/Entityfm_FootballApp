using System.Collections.Generic;

namespace Entityfm_FootballApp
{
    public class Team
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public short establishment { get; set; }

        public ICollection<Player> Players { get; set; }

        public ICollection<Sponsor> Sponsors { get; set; } // One sponsor can support more than 1 team
    }
}
