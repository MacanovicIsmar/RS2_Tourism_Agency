

using Microsoft.AspNetCore.Mvc;
using TourismAgency.Services;

namespace RS2_Tourism_Agency.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class PutovanjeController:ControllerBase
    {
        private readonly IPutovanjaServices _PutovanjeService;


        public PutovanjeController(IPutovanjaServices PutovanjeService)
        {

            _PutovanjeService = PutovanjeService;


        }



        [HttpGet]
        public IEnumerable<Putovanja> Get(string naziv ,string sifra)
        {

           

            return _PutovanjeService.Get();
        
        
        
        }
        [HttpGet("{id}")]
        public Putovanja GetbyId(int id)
        {



            return _PutovanjeService.GetbyId(id);



        }



        //public IEnumerable<Putovanja> GetbyId(int Id)
        //{



        //    return _PutovanjeService.Get();



        //}




    }
}
