using System;
using System.Collections.Generic;

namespace RS2_Tourism_Agency.Model
{
    public partial class KorisniciUloge
    {
        public int Id { get; set; }
        public int KorisnikId { get; set; }
        public int UlogaId { get; set; }
        public DateTime DatumIzmjene { get; set; }
        public virtual Uloge Uloga { get; set; }
    }
}
