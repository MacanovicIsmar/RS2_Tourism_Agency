using System;
using System.Collections.Generic;

namespace RS2_Tourism_Agency.Model
{
    public class Country
    {
        //public Country()
        //{
        //    Putovanjes = new HashSet<Putovanje>();
        //}

        public int Id { get; set; }
        public string Naziv { get; set; }

        //public virtual ICollection<Putovanje> Putovanjes { get; set; }
    }
}
