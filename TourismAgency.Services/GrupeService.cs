using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismAgency.Services.Database;

namespace TourismAgency.Services
{
    public class GrupeService : IGrupeService
    {
        //dodano V2
        public Rs2_SeminarskiContext context { get;  set;}

        public IMapper Mapper { get; set;}




        //dodano V2
        public GrupeService(Rs2_SeminarskiContext context_ ,IMapper mapper_)
        {

            context = context_;
            Mapper = mapper_;
        
        
        
        }




        public IEnumerable<RS2_Tourism_Agency.Model.Grupe> Get()
        {
            

            var result = context.Grupe.ToList();

            return Mapper.Map<List<RS2_Tourism_Agency.Model.Grupe>>(result);



            //var tmp = context.Putovanja.ToList();

        }

        public RS2_Tourism_Agency.Model.Grupe GetbyId(int id)
        {

            var result =context.Grupe.Find(id);


            return Mapper.Map<RS2_Tourism_Agency.Model.Grupe>(result);

        }



    }
}



//public List<Putovanje> Putovanja = new List<Putovanje>()
//    {
//        new Putovanje()
//        {
//            Id=1,
//            Naziv="London"

//        },

//        new Putovanje()
//        {
//            Id=1,
//            Naziv="Berlin"

//        }



//    };