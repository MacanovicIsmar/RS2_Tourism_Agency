using System;
using System.Collections.Generic;

namespace TourismAgency.Services.Database
{
    public partial class Zaduzenja
    {
        public int Id { get; set; }
        public string? Naziv { get; set; }
        public int? PutovanjeId { get; set; }
        public int? VodicId { get; set; }
        public int? GrupaId { get; set; }

        public virtual Grupe? Grupa { get; set; }
        public virtual Putovanje? Putovanje { get; set; }
        public virtual Vodic? Vodic { get; set; }
    }
}
