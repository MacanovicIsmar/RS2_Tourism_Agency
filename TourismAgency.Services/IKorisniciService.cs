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
    public interface IKorisniciService:
        ICRUDService<Korisnici,BaseSearchObject,UpsertKorisnikRequest, UpsertKorisnikRequest>
    {
        IEnumerable<Korisnici> Get();

    }
}
