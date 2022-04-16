using System;
using System.Collections.Generic;

namespace TourismAgency.Services.Database
{
    public partial class Vodic
    {
        public Vodic()
        {
            Grupes = new HashSet<Grupe>();
            Korisniks = new HashSet<Korisnik>();
            Zaduzenjas = new HashSet<Zaduzenja>();
        }

        public int Id { get; set; }
        public int? BrojObavljenihZaduzenja { get; set; }
        public int? BrojZaduzenih { get; set; }

        public virtual ICollection<Grupe> Grupes { get; set; }
        public virtual ICollection<Korisnik> Korisniks { get; set; }
        public virtual ICollection<Zaduzenja> Zaduzenjas { get; set; }
    }
}
