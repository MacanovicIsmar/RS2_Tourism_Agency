using System;
using System.Collections.Generic;
using System.Linq;
//dodano v2
namespace RS2_Tourism_Agency.Model
{
    public class Korisnici
    {
       

        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        //public string Password { get; set; }
        //public string PasswordSalt { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }

        public bool? Status { get; set; }
        public string Role { get; set; }

        //public int? RezervacijaId { get; set; }
        //public int? TuristId { get; set; }
        //public int? VodicId { get; set; }

        //public virtual Rezervacija? Rezervacija { get; set; }
        //public virtual Turist? Turist { get; set; }
        //public virtual Vodic? Vodic { get; set; }
        //public virtual ICollection<Notifikacija> Notifikacijas { get; set; }
        public virtual ICollection<KorisniciUloge> KorisniciUloges { get; set; }

        public string RoleNames => String.Join(", ",KorisniciUloges?.Select(X => X.Uloga?.Naziv)?
            .ToList());
            

    }
}
