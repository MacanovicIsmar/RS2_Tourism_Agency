using AutoMapper;
using RS2_Tourism_Agency.Model.SearchObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismAgency.Services.Database;

namespace TourismAgency.Services
{
    public class GrupeService :BaseService<RS2_Tourism_Agency.Model.Grupe,Grupe,GrupeSearchObject> ,IGrupeService
    {
        //dodano V2
        //public Rs2_SeminarskiContext context { get;  set;}

        //public IMapper Mapper { get; set;}




        //dodano V2
        public GrupeService(Rs2_SeminarskiContext context_ ,IMapper mapper_):base(context_, mapper_)
        {

            //context = context_;
            //Mapper = mapper_;
              
        }

        public override IQueryable<Grupe> AddFilter(IQueryable<Grupe> query, GrupeSearchObject search = null)
        {
            var filterquer = base.AddFilter(query, search);

            if (!string.IsNullOrWhiteSpace(search?.OznakaGrupe))
            {

                filterquer = filterquer.Where(x => x.OznakaGrupe == search.OznakaGrupe);

            }

            if (search?.BrojSlobodnihMjesta!=null)
            {

                filterquer = filterquer.Where(x => x.BrojSlobodnihMjesta == search.BrojSlobodnihMjesta);

            }

            if (search?.GrupaId.HasValue == true)
            {

                filterquer = filterquer.Where(x => x.Id == search.GrupaId);

            }

           


            return filterquer;

        }


        //public IEnumerable<RS2_Tourism_Agency.Model.Grupe> Get()
        //{


        //    var result = context.Grupe.ToList();

        //    return Mapper.Map<List<RS2_Tourism_Agency.Model.Grupe>>(result);



        //    //var tmp = context.Putovanja.ToList();

        //}

        //public RS2_Tourism_Agency.Model.Grupe GetbyId(int id)
        //{

        //    var result =context.Grupe.Find(id);


        //    return Mapper.Map<RS2_Tourism_Agency.Model.Grupe>(result);

        //}



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