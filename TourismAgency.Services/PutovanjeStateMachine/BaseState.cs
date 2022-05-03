
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using RS2_Tourism_Agency.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismAgency.Services.Database;

namespace TourismAgency.Services.PutovanjeStateMachine
{
    public class BaseState
    {
        public IMapper Mapper { get; set; }

        public IServiceProvider ServiceProvider { get; set; }

        public Rs2_SeminarskiContext Context { get; set; }

        public BaseState(IMapper Mapper_ , IServiceProvider ServiceProvider_,Rs2_SeminarskiContext Context_)
        {
            Mapper = Mapper_;
            ServiceProvider=ServiceProvider_ ;
            Context=Context_;



        }





        public Putovanje CurrentEntity { get; set; }
        public string CurrentState { get; set; }

      

        //public BaseState 
        //{



        //}




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

        public BaseState CreateState(string statename )
        {
           

            switch (statename)
            {
             case "Initial":
                    return ServiceProvider.GetService<InitialPutovanjeState>();
                    break;
                case "Draft":
                    return ServiceProvider.GetService<PutovanjaDraftState>();

                case "Active":
                    return ServiceProvider.GetService<PutovanjeActiveState>();

                default:
                    throw new Exception("Not supported");

            }
               
            
        }
        public virtual List<string> AllowedActions()
        {

           return new List<string>();
        
        
        }



    }
}
