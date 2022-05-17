using AutoMapper;
using RS2_Tourism_Agency.Model.SearchObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismAgency.Services.Database;

//dodano V3
namespace TourismAgency.Services
{
    public class BaseService<T,TDb,TSearch> : Iservice<T, TSearch> where T : class where TDb : class where TSearch : BaseSearchObject
    {

        
        public Rs2_SeminarskiContext context { get; set; }

        public IMapper Mapper { get; set; }




        
        public BaseService(Rs2_SeminarskiContext context_, IMapper mapper_)
        {

            context = context_;
            Mapper = mapper_;



        }

        public virtual IQueryable<TDb> AddFilter (IQueryable<TDb>  query ,TSearch search=null) 
        {


            return query;
        
        }

        public virtual IQueryable<TDb> AddInclude(IQueryable<TDb> query, TSearch search = null)
        {


            return query;

        }







        public virtual IEnumerable<T> Get(TSearch search=null)
        {
            var entity = context.Set<TDb>().AsQueryable();

            entity = AddFilter(entity, search);

            entity = AddInclude(entity, search);

            if (search?.Page.HasValue==true && search?.PageSize.HasValue==true)
            {
                
                if (search?.Page.HasValue == true)
                {

                    entity = entity.Take(search.PageSize.Value).Skip(search.Page.Value * search.PageSize.Value);

                }



            }



            var result = entity.ToList();

            return Mapper.Map<List<T>>(result);
        }

        public T GetbyId(int id)
        {
            var result = context.Set<TDb>().Find(id);


            return Mapper.Map<T>(result);
        }
    }
}
