﻿using System;
using System.Collections.Generic;

namespace TourismAgency.Services.Database
{
    public partial class Rezervacija
    {
        public int Id { get; set; }
        public string? Naziv { get; set; }
        public int? PutovanjeId { get; set; }
        public int? BrojLjudi { get; set; }
        public int? SmjestajId { get; set; }

        public virtual Putovanje? Putovanje { get; set; }
        public virtual Smjestaj? Smjestaj { get; set; }
        public virtual Korisnik? Korisnik { get; set; }
    }
}
