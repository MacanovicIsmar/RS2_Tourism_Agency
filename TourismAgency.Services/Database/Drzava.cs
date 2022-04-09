using System;
using System.Collections.Generic;

namespace TourismAgency.Services.Database
{
    public partial class Drzava
    {
        public Drzava()
        {
            Putovanjes = new HashSet<Putovanje>();
        }

        public int Id { get; set; }
        public string? Naziv { get; set; }

        public virtual ICollection<Putovanje> Putovanjes { get; set; }
    }
}
