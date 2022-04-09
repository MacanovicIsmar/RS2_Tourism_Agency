







using RS2_Tourism_Agency.Model;

namespace TourismAgency.Services
{
    public interface IPutovanjaServices
    {
        IEnumerable<Putovanje> Get();

        Putovanje GetbyId(int id);

    }



}