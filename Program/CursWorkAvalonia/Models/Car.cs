using System;
using System.Collections.Generic;

namespace CursWorkAvalonia
{
    public partial class Car
    {
        public Car()
        {
            Team = new HashSet<Team>();

        }
        public long Id { get; set; }
        public long? DriverId { get; set; }
        public long? ChassisId { get; set; }
        public long? TournamentId { get; set; }

        public virtual Driver? Driver { get; set; }
        public virtual Chassis? Chassis { get; set; }
        public virtual ICollection<Team> Team { get; set; }
    }
}
