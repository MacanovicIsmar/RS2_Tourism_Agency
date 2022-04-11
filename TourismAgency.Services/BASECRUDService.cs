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
    public class BASECRUDService <T,TDb, TSearch,TInsert, TUpdate>                   
        :BaseService<T, TDb, TSearch>,
        ICRUDService<T, TSearch, TInsert, TUpdate>
        where T : class
        where TDb : class
        where TSearch : BaseSearchObject        
        where TInsert : class
        where TUpdate : class
    {




        public BASECRUDService(Rs2_SeminarskiContext context_, IMapper mapper_)
        :base(context_, mapper_)
        {

         

        }

        //public IEnumerable<T> Get(TSearch search = null)
        //{
        //    throw new NotImplementedException();
        //}

        //public T GetbyId(int id)
        //{
        //    throw new NotImplementedException();
        //}

        public T Insert(TInsert Insert)
        {
            var set = context.Set<TDb>();

            TDb entity = Mapper.Map<TDb>(Insert);

            set.Add(entity);

            context.SaveChanges();

            return Mapper.Map<T>(entity);
        }

        public T Update(int Id, TUpdate Update)
        {
            throw new NotImplementedException();
        }
    }
}
