using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TourismAgency.Services;

namespace RS2_Tourism_Agency.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]

    public class BaseController<T,TSearch> :ControllerBase where T :class where TSearch:class
    {
        public  Iservice<T,TSearch> Service {get; set;}

        public BaseController(Iservice<T,TSearch> Service_)
        {

            Service = Service_;
             
        }

        [HttpGet]
        public virtual IEnumerable<T> Get([FromQuery]TSearch search=null)
        {


            return Service.Get(search);

            //if (_PutovanjeService != null)
            //{

            //    _PutovanjeService.Get();


            //}


        }
        [HttpGet("{id}")]
        public virtual T GetbyId(int id)
        {



            return Service.GetbyId(id);



        }









    }
}
