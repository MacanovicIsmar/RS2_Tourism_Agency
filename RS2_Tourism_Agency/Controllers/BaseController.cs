using Microsoft.AspNetCore.Mvc;
using TourismAgency.Services;

namespace RS2_Tourism_Agency.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class BaseController<T,TSearch> :ControllerBase where T :class where TSearch:class
    {
        public  Iservice<T,TSearch> Service {get; set;}

        public BaseController(Iservice<T,TSearch> Service_)
        {

            Service = Service_;
             
        }

        [HttpGet]
        public IEnumerable<T> Get([FromQuery]TSearch search=null)
        {


            return Service.Get(search);

            //if (_PutovanjeService != null)
            //{

            //    _PutovanjeService.Get();


            //}


        }
        [HttpGet("{id}")]
        public T GetbyId(int id)
        {



            return Service.GetbyId(id);



        }









    }
}
