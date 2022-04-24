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








    }
}

//inheriting base 
//using idrzava service