using System;
using System.Collections.Generic;

namespace CursWorkAvalonia
{
    public partial class Chassis
    {
        public Chassis()
        {
            Car = new HashSet<Car>();
        }

        public long Id { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Car> Car { get; set; }
    }
}