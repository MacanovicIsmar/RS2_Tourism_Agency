using System;
using System.Collections.Generic;

namespace TourismAgency.Services.Database
{
    public partial class Notifikacija
    {
        public int Id { get; set; }
        public string? Naslov { get; set; }
        public string? Opis { get; set; }
        public string? Osoba { get; set; }
        public int? KorisnikId { get; set; }

        public virtual Korisnik? Korisnik { get; set; }
    }
}
