using System;

namespace Entityfm_FootballApp
{
    public class Player
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime BirthDate { get; set; }

        public Team Team { get; set; } // One to many relation

        public PlayerAddress Address { get; set; }
    }
}
