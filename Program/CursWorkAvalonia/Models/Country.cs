using System;
using System.Collections.Generic;

namespace CursWorkAvalonia
{
    public partial class Country
    {
        public Country()
        {
            Driver = new HashSet<Driver>();
        }

        public long Id { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Driver> Driver { get; set; }
    }
}
