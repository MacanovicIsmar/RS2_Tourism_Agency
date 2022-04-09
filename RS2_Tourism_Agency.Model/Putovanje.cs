using System;
using System.Collections.Generic;
using System.Text;

namespace RS2_Tourism_Agency.Model
{
    public class Putovanje
    {
       

        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Polazak { get; set; }
        public int GrupaId { get; set; }
        public int DrzavaId { get; set; }
        public string Opis { get; set; }

        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }

        public bool? Status { get; set; }



        //public virtual Drzava? Drzava { get; set; }
        //public virtual Grupe IdNavigation { get; set; } 
        //public virtual ICollection<Lokacija> Lokacijas { get; set; }
        //public virtual ICollection<PlanAktivnosti> PlanAktivnostis { get; set; }
        //public virtual ICollection<Rezervacija> Rezervacijas { get; set; }
        //public virtual ICollection<Zaduzenja> Zaduzenjas { get; set; }



    }
}
