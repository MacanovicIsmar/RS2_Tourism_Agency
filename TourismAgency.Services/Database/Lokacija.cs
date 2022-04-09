using System;
using System.Collections.Generic;

namespace TourismAgency.Services.Database
{
    public partial class Lokacija
    {
        public int Id { get; set; }
        public string? Adresa { get; set; }
        public int? PutovanjeId { get; set; }
        public int? SmjestajId { get; set; }

        public virtual Putovanje? Putovanje { get; set; }
        public virtual Smjestaj? Smjestaj { get; set; }
    }
}
