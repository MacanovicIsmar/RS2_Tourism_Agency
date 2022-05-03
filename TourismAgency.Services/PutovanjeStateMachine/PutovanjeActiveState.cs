using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismAgency.Services.Database;

namespace TourismAgency.Services.PutovanjeStateMachine
{
    public class PutovanjeActiveState:BaseState
    {
        public PutovanjeActiveState(IMapper Mapper_, IServiceProvider ServiceProvider_, Rs2_SeminarskiContext Context_)
          : base(Mapper_, ServiceProvider_, Context_)
        {





        }



    }
}
