
using RS2_Tourism_Agency.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismAgency.Services.Database;

namespace TourismAgency.Services.PutovanjeStateMachine
{
    public abstract class BaseState
    {

        public Putovanje CurrentEntity { get; set; }
        public string CurrentState { get; set; }

        public Rs2_SeminarskiContext Context { get; set; }

        public virtual RS2_Tourism_Agency.Model.Putovanje Insert(PutovanjeInsertRequest request)
        {


            throw new Exception("Not Allowed");



        }
        public virtual void Update(PutovanjeUpdateRequest request)
        {


            throw new Exception("Not Allowed");



        }
        public virtual void Activate()
        {


            throw new Exception("Not Allowed");



        }
        public virtual void Hide()
        {


            throw new Exception("Not Allowed");



        }
        public virtual void Delete()
        {


            throw new Exception("Not Allowed");


        }

        public static BaseState CreateState(string statename )
        {
           

            switch (statename)
            {
             case "Initial":
                  return new InitialPutovanjeState();
                    break;
                case "Draft":
                    return new PutovanjaDraftState();

                case "Active":
                    return new PutovanjeActiveState();

                default:
                    throw new Exception("Not supported");

            }
               
            



        }



    }
}
