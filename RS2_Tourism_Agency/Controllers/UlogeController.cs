

using Microsoft.AspNetCore.Mvc;
using RS2_Tourism_Agency.Model;
using RS2_Tourism_Agency.Model.Request;
using RS2_Tourism_Agency.Model.SearchObjects;
using TourismAgency.Services;

namespace RS2_Tourism_Agency.Controllers
{

   

    public class UlogeController : BaseController<Uloge, RS2_Tourism_Agency.Model.SearchObjects.BaseSearchObject>
       
    {
        //private readonly IGrupeService _GrupeService;


        public UlogeController(Iservice<RS2_Tourism_Agency.Model.Uloge, RS2_Tourism_Agency.Model.SearchObjects.BaseSearchObject> service):base(service)
        {

           //_GrupeService = GrupeService;


        }







    }
}
