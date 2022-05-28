using System;
using System.Collections.Generic;

namespace CursWorkAvalonia
{
    public partial class Gender
    {
        public Gender()
        {
            Driver = new HashSet<Driver>();
        }

        public long Id { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Driver> Driver { get; set; }
    }
}
