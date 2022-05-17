


//sve dodano v2

using Microsoft.AspNetCore.Authorization;
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
    [Authorize]

    public class KorisnikController : BaseCRUDController
        <
        Korisnici,
        KorisniciSearchObject,
        KorisniciInsertRequest,
        KorisnikUpdateRequest

        >
    {
        private readonly IKorisniciService _KorisniciService;


        public KorisnikController(IKorisniciService KorisniciService_) : base(KorisniciService_)
        {

            _KorisniciService = KorisniciService_;


        }

        //[Authorize("Administrator")]

        public override Korisnici Insert([FromBody] KorisniciInsertRequest insert)
        {
            return base.Insert(insert);


        }


        //[Authorize("Administrator")]
        public override Korisnici Update(int Id, [FromBody] KorisnikUpdateRequest Update)
        {  
            return base.Update(Id, Update);



        }





    }
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