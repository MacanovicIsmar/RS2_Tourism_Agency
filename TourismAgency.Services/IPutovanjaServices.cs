





namespace TourismAgency.Services
{
    public interface IPutovanjaServices
    {
        IEnumerable<Putovanja> Get();

        Putovanja GetbyId(int id);

    }



}