using System;
using System.Collections.Generic;

namespace TourismAgency.Services.Database
{
    public partial class PlanAktivnosti2
    {
        public int Id { get; set; }
        public string? Datum { get; set; }
        public string? Vrijeme { get; set; }
        public string? Opis { get; set; }
        public int? PutovanjeId { get; set; }
    }
}
