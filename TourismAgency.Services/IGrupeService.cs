using RS2_Tourism_Agency.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourismAgency.Services
{
    public interface IGrupeService
    {
        IEnumerable<Grupe> Get();

        Grupe GetbyId(int id);
    }
}
