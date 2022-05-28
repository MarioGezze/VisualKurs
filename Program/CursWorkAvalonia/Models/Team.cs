using System;
using System.Collections.Generic;

namespace CursWorkAvalonia
{
    public partial class Team
    {
        public long Id { get; set; }
        public long? CarId { get; set; }
        public long? Name { get; set; }
        public long? TournamentId { get; set; }

        public virtual Car? Car { get; set; }
        public virtual Tournament? Tournament { get; set; }
    }
}