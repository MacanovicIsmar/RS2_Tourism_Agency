using System;
using System.Collections.Generic;

namespace TourismAgency.Services.Database
{
    public partial class Uloge
    {
        public Uloge()
        {
            KorisniciUloges = new HashSet<KorisniciUloge>();
        }

        public int Id { get; set; }
        public string? Naziv { get; set; }
        public string? Opis { get; set; }

        public virtual ICollection<KorisniciUloge> KorisniciUloges { get; set; }
    }
}
