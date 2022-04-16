using System;
using System.Collections.Generic;

namespace TourismAgency.Services.Database
{
    public partial class Smjestaj
    {
        public Smjestaj()
        {
            Lokacijas = new HashSet<Lokacija>();
            Rezervacijas = new HashSet<Rezervacija>();
        }

        public int Id { get; set; }
        public string? NazivHotela { get; set; }
        public string? Adresa { get; set; }
        public string? BrojZvijezdica { get; set; }
        public string? Slika { get; set; }

        public virtual ICollection<Lokacija> Lokacijas { get; set; }
        public virtual ICollection<Rezervacija> Rezervacijas { get; set; }
    }
}
