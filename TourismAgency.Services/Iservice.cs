using RS2_Tourism_Agency.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourismAgency.Services
{
    public interface Iservice<T,TSearch> where T :class where TSearch : class
    {
        IEnumerable<T> Get(TSearch search = null);

        T GetbyId(int id);


    }
}
