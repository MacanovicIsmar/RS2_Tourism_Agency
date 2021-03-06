using System;
using System.Collections.Generic;

namespace TourismAgency.Services.Database
{
    public partial class PlanAktivnosti
    {
        public int Id { get; set; }
        public DateTime? Datum { get; set; }
        public TimeSpan? Vrijeme { get; set; }
        public string? Opis { get; set; }
        public int? PutovanjeId { get; set; }

        public virtual Putovanje? Putovanje { get; set; }
    }
}
