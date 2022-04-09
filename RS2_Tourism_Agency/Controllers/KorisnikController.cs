


//sve dodano v2

using Microsoft.AspNetCore.Mvc;
using RS2_Tourism_Agency.Model;
using TourismAgency.Services;
using TourismAgency.Services.Database;

namespace RS2_Tourism_Agency.Controllers
{



    [ApiController]
    [Route("[controller]")]

    public class KorisnikController : ControllerBase
    {
        private readonly IKorisniciService _KorisniciService;


        public KorisnikController(IKorisniciService KorisniciService)
        {

            _KorisniciService = KorisniciService;


        }



        [HttpGet]
        public IEnumerable<Korisnici> Get()
        {

            return _KorisniciService.Get();




        }
        //[HttpGet("{id}")]
        //public Korisnik GetbyId(int id)
        //{



        //    return _PutovanjeService.GetbyId(id);



        //}

    }
}
