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
    public class InitialPutovanjeState : BaseState
    {

        public InitialPutovanjeState(IMapper Mapper_, IServiceProvider ServiceProvider_, Rs2_SeminarskiContext Context_)
            :base(Mapper_, ServiceProvider_, Context_)
        { 
        
        
        
        
        
        }



        public override RS2_Tourism_Agency.Model.Putovanje Insert(PutovanjeInsertRequest request)
        {
            
            //sets vasriable to putovanje
            var set = Context.Set<Database.Putovanje>();

            Database.Putovanje Entity = Mapper.Map<Database.Putovanje>(request);

            CurrentEntity = Entity;

            CurrentEntity.StateMachine = "Draft";

            set.Add(Entity);

            Context.SaveChanges();

            return Mapper.Map<RS2_Tourism_Agency.Model.Putovanje>(Entity);

            //base.Insert(request);

            //call entity framework to persist data;
     

        }






    }
}
