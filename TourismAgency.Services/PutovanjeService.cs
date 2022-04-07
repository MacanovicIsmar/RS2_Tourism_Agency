using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourismAgency.Services
{
    public class PutovanjeService : IPutovanjaServices
    {
        public List<Putovanja> Putovanja = new List<Putovanja>()
            {
                new Putovanja()
                {
                    Id=1,
                    Name="London"

                },

                new Putovanja()
                {
                    Id=1,
                    Name="Berlin"

                }



            };


        public IEnumerable<Putovanja> Get()
        {
            return Putovanja;




        }

        public Putovanja GetbyId(int id)
        {


            return Putovanja.FirstOrDefault(X => X.Id == id);
        
        
        }



    }
}
