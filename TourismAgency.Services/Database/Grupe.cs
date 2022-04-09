using System;
using System.Collections.Generic;

namespace TourismAgency.Services.Database
{
    public partial class Grupe
    {
        public Grupe()
        {
            Turists = new HashSet<Turist>();
        }

        public int Id { get; set; }
        public string? OznakaGrupe { get; set; }
        public int? BrojSlobodnihMjesta { get; set; }
        public int? BrojZauzetihMjesta { get; set; }
        public int? VodicId { get; set; }

        public virtual Vodic? Vodic { get; set; }
        public virtual Putovanje Putovanje { get; set; } = null!;
        public virtual Zaduzenja? Zaduzenja { get; set; }
        public virtual ICollection<Turist> Turists { get; set; }
    }
}
