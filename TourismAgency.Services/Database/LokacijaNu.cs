using System;
using System.Collections.Generic;

namespace TourismAgency.Services.Database
{
    public partial class LokacijaNu
    {
        public int Id { get; set; }
        public string? Adresa { get; set; }
        public int? PutovanjeId { get; set; }
        public int? SmjestajId { get; set; }
    }
}
