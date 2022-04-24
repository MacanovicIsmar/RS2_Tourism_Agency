﻿using System;
using System.Collections.Generic;

namespace TourismAgency.Services.Database
{
    public partial class KorisniciUloge
    {
        public int Id { get; set; }
        public int KorisnikId { get; set; }
        public int UlogaId { get; set; }
        public DateTime DatumIzmjene { get; set; }

        public virtual Korisnik Korisnik { get; set; } = null!;
        public virtual Uloge Uloga { get; set; } = null!;
    }
}
