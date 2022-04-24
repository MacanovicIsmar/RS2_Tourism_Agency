using AutoMapper;
using RS2_Tourism_Agency.Model.Request;
using RS2_Tourism_Agency.Model.SearchObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismAgency.Services.Database;
using TourismAgency.Services.PutovanjeStateMachine;

namespace TourismAgency.Services
{
    public class PutovanjaService : 
        BASECRUDService<
            RS2_Tourism_Agency.Model.Putovanje, 
            Putovanje,
            PutovanjaSearchObject,
            PutovanjeInsertRequest,
            PutovanjeUpdateRequest>, 
        IPutovanjaServices
    {
        
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







        //dodano v4

        public override RS2_Tourism_Agency.Model.Putovanje Insert(PutovanjeInsertRequest Insert)
        {
            var state = BaseState.CreateState("Initial");
            state.Context = context;
            return state.Insert(Insert);
             
        }

        public override RS2_Tourism_Agency.Model.Putovanje Update(int Id, PutovanjeUpdateRequest Update)
        {
            var product = context.Putovanjes.Find(Id);

            var state = BaseState.CreateState(product.StateMachine);

            state.Context = context;
            state.CurrentEntity = product;

            state.Update(Update);

            return GetbyId(Id);

            

        }



        public RS2_Tourism_Agency.Model.Putovanje Activate(int Id)
        {
            var product = context.Putovanjes.Find(Id);

            var state = BaseState.CreateState(product.StateMachine);

            state.Context = context;
            state.CurrentEntity = product;
            state.Activate();
           

            return GetbyId(Id);

            
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

//dodano V2
//public Rs2_SeminarskiContext context { get; set; }

//public IMapper Mapper { get; set;}
