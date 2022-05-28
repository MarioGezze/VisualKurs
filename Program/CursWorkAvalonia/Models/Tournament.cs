using System;
using System.Collections.Generic;

namespace CursWorkAvalonia
{
    public partial class Tournament
    {
        public Tournament()
        {
            Team = new HashSet<Team>();
        }

        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Time { get; set; }

        public virtual ICollection<Team> Team { get; set; }
    }
}
