


//sve dodano v2

using Microsoft.AspNetCore.Mvc;
using RS2_Tourism_Agency.Model;
using RS2_Tourism_Agency.Model.Request;
using RS2_Tourism_Agency.Model.SearchObjects;
using TourismAgency.Services;
using TourismAgency.Services.Database;

namespace RS2_Tourism_Agency.Controllers
{



    [ApiController]
    [Route("[controller]")]

    public class KorisnikController : BaseCRUDController
        <
        Korisnici,
        BaseSearchObject,
        UpsertKorisnikRequest,
        UpsertKorisnikRequest

        >
    {
        private readonly IKorisniciService _KorisniciService;


        public KorisnikController(IKorisniciService KorisniciService_):base(KorisniciService_)
        {

            _KorisniciService = KorisniciService_;


        }



        //[HttpGet]
        //public IEnumerable<Korisnici> Get2()
        //{

            
        //    return _KorisniciService.Get();




        //}


        //[HttpGet("{id}")]
        //public Korisnik GetbyId(int id)
        //{



        //    return _PutovanjeService.GetbyId(id);



        //}

    }
}
