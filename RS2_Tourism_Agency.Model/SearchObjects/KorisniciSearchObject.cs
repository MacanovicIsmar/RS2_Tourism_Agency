using System;
using System.Collections.Generic;
using System.Text;

namespace RS2_Tourism_Agency.Model.SearchObjects
{
    public class KorisniciSearchObject:BaseSearchObject
    {
        public string Ime { get; set; }
        public string NameFTS { get; set; }

        public string KorisnickoIme { get; set; }

        public bool IncludeRules { get; set;}


    }
}
