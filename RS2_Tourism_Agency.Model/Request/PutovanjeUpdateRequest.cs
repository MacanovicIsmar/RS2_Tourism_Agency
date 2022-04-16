using System;
using System.Collections.Generic;
using System.Text;

namespace RS2_Tourism_Agency.Model.Request
{
    public class PutovanjeUpdateRequest
    {

        //public int ID { get; set; }
        public string Naziv { get; set; }
        public string Polazak { get; set; }

        public int DrzavaId { get; set; }
        public string Opis { get; set; }

        //public byte[] Slika { get; set; }
        //public byte[] SlikaThumb { get; set; }

        public bool? Status { get; set; }





    }
}
