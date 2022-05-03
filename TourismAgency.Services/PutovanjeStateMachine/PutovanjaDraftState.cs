using AutoMapper;
using RS2_Tourism_Agency.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismAgency.Services.Database;

namespace TourismAgency.Services.PutovanjeStateMachine
{
    public class PutovanjaDraftState:BaseState
    {
        public PutovanjaDraftState(IMapper Mapper_, IServiceProvider ServiceProvider_, Rs2_SeminarskiContext Context_)
           : base(Mapper_, ServiceProvider_, Context_)
        {





        }
        public override void Update(PutovanjeUpdateRequest request)
        {
            var set = Context.Set<Putovanje>();

            Mapper.Map(request, CurrentEntity);
            CurrentEntity.StateMachine = "Draft";

            Context.SaveChanges();

        }
        public override void Activate()
        {
            //base.Activate();

            CurrentEntity.StateMachine = "Active";
            Context.SaveChanges();
        }

        public override List<string> AllowedActions()
        {
            var list = base.AllowedActions();
            list.Add("Update");
            list.Add("Activate");


            return list;
        }

    }
}
