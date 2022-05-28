using System;
using System.Collections.Generic;

namespace CursWorkAvalonia
{
    public partial class Driver
    {
        public Driver()
        {
            Car = new HashSet<Car>();

        }

        public long Id { get; set; }
        public string? Name { get; set; }
        public long? GenderId { get; set; }
        public long? Age { get; set; }
        public long? CountryId { get; set; }

        public virtual Country? Country { get; set; }
        public virtual Gender? Gender { get; set; }
        public virtual ICollection<Car> Car { get; set; }
    }
}
