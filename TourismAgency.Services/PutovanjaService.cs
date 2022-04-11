using AutoMapper;
using RS2_Tourism_Agency.Model.Request;
using RS2_Tourism_Agency.Model.SearchObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismAgency.Services.Database;

namespace TourismAgency.Services
{
    public class PutovanjaService : 
        BASECRUDService<
            RS2_Tourism_Agency.Model.Putovanje, 
            Putovanje,
            PutovanjaSearchObject,
            PutovanjeInsertRequest,
            PutovanjeInsertRequest>, 
        IPutovanjaServices
    {
        //dodano V2
        //public Rs2_SeminarskiContext context { get; set; }

        //public IMapper Mapper { get; set;}




        //dodano V2
        public PutovanjaService(Rs2_SeminarskiContext context_, IMapper mapper_) : base(context_, mapper_)
        {

            //context = context_;
            //Mapper = mapper_;



        }


        //v3 changing addfilter in base Service
        public override IQueryable<Putovanje> AddFilter(IQueryable<Putovanje> query, PutovanjaSearchObject search = null)
        {
            var filterquer = base.AddFilter(query, search);

            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {

                filterquer = filterquer.Where(x => x.Naziv == search.Naziv);
            
            }

            if (!string.IsNullOrWhiteSpace(search?.Opis))
            {

                filterquer = filterquer.Where(x => x.Opis == search.Opis);

            }



            return filterquer;

        }












        //public override IEnumerable<RS2_Tourism_Agency.Model.Putovanje> Get(PutovanjaSearchObject search=null)
        //{

        //    return base.Get(search);

        //}
        //public override IEnumerable<RS2_Tourism_Agency.Model.Putovanje> Get()
        //{

        //    return base.Get();

        //}




        //public List<RS2_Tourism_Agency.Model.Putovanje> GetByName(string name)
        //{

        //    var result = context.Putovanja.Where(X => X.Naziv == name).ToList();


        //}





        //public IEnumerable<RS2_Tourism_Agency.Model.Putovanje> Get()
        //{


        //    var result = context.Putovanja.ToList();

        //    return Mapper.Map<List<RS2_Tourism_Agency.Model.Putovanje>>(result);



        //    //var tmp = context.Putovanja.ToList();

        //}

        //public RS2_Tourism_Agency.Model.Putovanje GetbyId(int id)
        //{

        //    var result =context.Putovanja.Find(id);


        //    return Mapper.Map<RS2_Tourism_Agency.Model.Putovanje>(result);

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