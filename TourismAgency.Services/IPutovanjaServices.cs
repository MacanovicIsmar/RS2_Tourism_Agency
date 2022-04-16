







using RS2_Tourism_Agency.Model;
using RS2_Tourism_Agency.Model.Request;

namespace TourismAgency.Services
{
    public interface IPutovanjaServices
        :ICRUDService<Putovanje,RS2_Tourism_Agency.Model.SearchObjects.PutovanjaSearchObject, PutovanjeInsertRequest, PutovanjeUpdateRequest>
    {
        //IEnumerable<Putovanje> Get();

        //Putovanje GetbyId(int id);

    }



}