using RS2_Tourism_Agency.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourismAgency.Services.PutovanjeStateMachine
{
    public class PutovanjaDraftState:BaseState
    {

        public override void Update(PutovanjeUpdateRequest request)
        {
            //base.Update(request);

            CurrentEntity.StateMachine = "Draft";
            //update data by calling entity framework

        }
        public override void Activate()
        {
            //base.Activate();

            CurrentEntity.StateMachine = "Active";

        }


    }
}
