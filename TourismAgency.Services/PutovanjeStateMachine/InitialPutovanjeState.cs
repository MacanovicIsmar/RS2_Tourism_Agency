using RS2_Tourism_Agency.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourismAgency.Services.PutovanjeStateMachine
{
    public class InitialPutovanjeState : BaseState
    {
        public override RS2_Tourism_Agency.Model.Putovanje Insert(PutovanjeInsertRequest request)
        {
            //base.Insert(request);

            //call entity framework to persist data;

            CurrentEntity.StateMachine = "Draft";


            return new RS2_Tourism_Agency.Model.Putovanje();

        }






    }
}
