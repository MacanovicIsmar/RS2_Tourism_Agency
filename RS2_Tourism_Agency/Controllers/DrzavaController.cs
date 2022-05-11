using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RS2_Tourism_Agency.Model;
using RS2_Tourism_Agency.Model.Request;
using RS2_Tourism_Agency.Model.SearchObjects;
using TourismAgency.Services;

namespace RS2_Tourism_Agency.Controllers
{
    public class DrzavaController :
        BaseCRUDController
        <
         Country,
         DrzavaSearchObject,
         DrzavaUpSetRequest,
         DrzavaUpSetRequest
        >
    {
        public DrzavaController(IDrzavaService Service_) : base(Service_)
        {



        }

        [AllowAnonymous]
        public override IEnumerable<Country> Get([FromQuery] DrzavaSearchObject search = null)
        {
            return base.Get(search);
        }

        [AllowAnonymous]
        public override Country GetbyId(int id)
        {
            return base.GetbyId(id);
        }





    }
}

//inheriting base 
//using idrzava service