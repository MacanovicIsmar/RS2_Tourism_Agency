

using Microsoft.AspNetCore.Mvc;
using RS2_Tourism_Agency.Model.Request;
using TourismAgency.Services;

namespace RS2_Tourism_Agency.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class PutovanjeController:
            BaseCRUDController<
            RS2_Tourism_Agency.Model.Putovanje,
            RS2_Tourism_Agency.Model.SearchObjects.PutovanjaSearchObject,
            PutovanjeInsertRequest,
            PutovanjeUpdateRequest
            > 
    {
        public IPutovanjaServices _PutovanjeService;


        public PutovanjeController(IPutovanjaServices PutovanjeService):base(PutovanjeService)
        {

            //_PutovanjeService = PutovanjeService;
            _PutovanjeService = PutovanjeService;

        }
        [HttpPut("{Id}/Activate")]
        public RS2_Tourism_Agency.Model.Putovanje Activate(int Id)
        {

            var result = _PutovanjeService.Activate(Id);

            return result;

        }
        [HttpPut("{Id}/AllowedActions")]
        public List<string> AllowedActions(int Id)
        {

            var result = _PutovanjeService.AllowedActions(Id);

            return result;

        }





    }
}

//[HttpGet]
//public IEnumerable<RS2_Tourism_Agency.Model.Putovanje> Get(string naziv, string sifra)
//{


//    return _PutovanjeService.Get();

//    //if (_PutovanjeService != null)
//    //{

//    //    _PutovanjeService.Get();


//    //}


//}
//[HttpGet("{id}")]
//public RS2_Tourism_Agency.Model.Putovanje GetbyId(int id)
//{



//    return _PutovanjeService.GetbyId(id);



//}



//public IEnumerable<Putovanja> GetbyId(int Id)
//{



//    return _PutovanjeService.Get();



//}