using System;
using System.Collections.Generic;

namespace TourismAgency.Services.Database
{
    public partial class Vodic
    {
        public Vodic()
        {
            Zaduzenjas = new HashSet<Zaduzenja>();
        }

        public int Id { get; set; }
        public int? BrojObavljenihZaduzenja { get; set; }
        public int? BrojZaduzenih { get; set; }

        public virtual Grupe? Grupe { get; set; }
        public virtual Korisnik? Korisnik { get; set; }
        public virtual ICollection<Zaduzenja> Zaduzenjas { get; set; }
    }
}
