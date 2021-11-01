using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkoutApp.Models
{
    public class Tournament
    {
        public int TournamentId { get; set; }
        public int AdminId { get; set; }
        public string TournamentName { get; set; }

        public virtual User Admin { get; set; }
    }
}
