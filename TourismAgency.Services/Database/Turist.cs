﻿using System;
using System.Collections.Generic;

namespace TourismAgency.Services.Database
{
    public partial class Turist
    {
        public int Id { get; set; }
        public int? BrojOdrađenihPutovanja { get; set; }
        public string? TrenutnoPutovanje { get; set; }
        public string? PopustStatus { get; set; }
        public int? GrupaId { get; set; }
        public int? BrojPutovanja { get; set; }

        public virtual Grupe? Grupa { get; set; }
        public virtual Korisnik? Korisnik { get; set; }
    }
}
