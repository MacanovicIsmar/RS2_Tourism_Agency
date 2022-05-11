using RS2_Tourism_Agency.Model;
using RS2_Tourism_Agency.Model.Request;
using RS2_Tourism_Agency.Model.SearchObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourismAgency.Services
{
    public interface IKorisniciService :
        ICRUDService<Korisnici, KorisniciSearchObject, KorisniciInsertRequest, KorisnikUpdateRequest>
    {
        //IEnumerable<Korisnici> Get();
        RS2_Tourism_Agency.Model.Korisnici Login(string username, string password);
    }
}
