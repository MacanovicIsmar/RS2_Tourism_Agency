

using Microsoft.AspNetCore.Mvc;
using RS2_Tourism_Agency.Model;
using RS2_Tourism_Agency.Model.SearchObjects;
using TourismAgency.Services;

namespace RS2_Tourism_Agency.Controllers
{

    //[ApiController]
    //[Route("[controller]")]

    public class GrupeController: BaseController<Grupe,GrupeSearchObject>
    {
        //private readonly IGrupeService _GrupeService;


        public GrupeController(IGrupeService GrupeService):base(GrupeService)
        {

            //_GrupeService = GrupeService;


        }



        //[HttpGet]
        //public IEnumerable<RS2_Tourism_Agency.Model.Grupe> Get(string naziv ,string sifra)
        //{
            

        //    return _GrupeService.Get();

        //    //if (_PutovanjeService != null)
        //    //{

        //    //    _PutovanjeService.Get();


        //    //}


        //}
        //[HttpGet("{id}")]
        //public RS2_Tourism_Agency.Model.Grupe GetbyId(int id)
        //{



        //    return _GrupeService.GetbyId(id);



        //}



        //public IEnumerable<Putovanja> GetbyId(int Id)
        //{



        //    return _PutovanjeService.Get();



        //}




    }
}
