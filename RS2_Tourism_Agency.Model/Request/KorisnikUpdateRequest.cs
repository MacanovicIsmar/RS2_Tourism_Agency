using System;
using System.Collections.Generic;
using System.Text;

namespace RS2_Tourism_Agency.Model.Request
{
    public class KorisnikUpdateRequest
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public bool? Status { get; set; }




    }
}
