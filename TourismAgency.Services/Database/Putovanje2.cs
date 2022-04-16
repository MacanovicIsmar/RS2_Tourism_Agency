using System;
using System.Collections.Generic;

namespace TourismAgency.Services.Database
{
    public partial class Putovanje2
    {
        public int Id { get; set; }
        public string? Naziv { get; set; }
        public string? Polazak { get; set; }
        public byte[]? Slika { get; set; }
        public byte[]? SlikaThumb { get; set; }
        public bool? Status { get; set; }
        public string? Opis { get; set; }
        public int? GrupaId { get; set; }
        public int? DrzavaId { get; set; }
    }
}
