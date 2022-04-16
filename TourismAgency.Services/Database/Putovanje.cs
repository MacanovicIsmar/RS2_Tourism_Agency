using System;
using System.Collections.Generic;

namespace TourismAgency.Services.Database
{
    public partial class Putovanje
    {
        public Putovanje()
        {
            Grupes = new HashSet<Grupe>();
            Lokacijas = new HashSet<Lokacija>();
            PlanAktivnostis = new HashSet<PlanAktivnosti>();
            Rezervacijas = new HashSet<Rezervacija>();
            Zaduzenjas = new HashSet<Zaduzenja>();
        }

        public int Id { get; set; }
        public string? Naziv { get; set; }
        public string? Polazak { get; set; }
        public byte[]? Slika { get; set; }
        public byte[]? SlikaThumb { get; set; }
        public bool? Status { get; set; }
        public string? Opis { get; set; }
        public int? DrzavaId { get; set; }

        public virtual Drzava? Drzava { get; set; }
        public virtual ICollection<Grupe> Grupes { get; set; }
        public virtual ICollection<Lokacija> Lokacijas { get; set; }
        public virtual ICollection<PlanAktivnosti> PlanAktivnostis { get; set; }
        public virtual ICollection<Rezervacija> Rezervacijas { get; set; }
        public virtual ICollection<Zaduzenja> Zaduzenjas { get; set; }
    }
}
