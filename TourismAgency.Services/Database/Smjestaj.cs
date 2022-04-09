using System;
using System.Collections.Generic;

namespace TourismAgency.Services.Database
{
    public partial class Smjestaj
    {
        public int Id { get; set; }
        public string? NazivHotela { get; set; }
        public string? Adresa { get; set; }
        public string? BrojZvijezdica { get; set; }
        public string? Slika { get; set; }

        public virtual Lokacija? Lokacija { get; set; }
        public virtual Rezervacija? Rezervacija { get; set; }
    }
}
