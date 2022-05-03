using Microsoft.AspNetCore.Mvc;
using TourismAgency.Services;

namespace RS2_Tourism_Agency.Controllers
{
    public class BaseCRUDController<T, TSearch,TInsert,TUpdate>
    : BaseController<T,TSearch>
        where T : class
        where TSearch : class
        where TInsert : class
        where TUpdate :class
    {
        public BaseCRUDController(ICRUDService<T, TSearch,TInsert,TUpdate> Service_) : base(Service_)
        {


        }


        [HttpPost]
        public T Insert([FromBody]TInsert insert)
        {

            var result=((ICRUDService<T, TSearch, TInsert, TUpdate>)this.Service).Insert(insert);

            return result;
        
        }

        [HttpPut("{Id}")]
        public T Update(int Id,[FromBody]TUpdate Update)
        {

            var result = ((ICRUDService<T, TSearch, TInsert, TUpdate>)this.Service).Update(Id, Update);

            return result;

        }


    }
}
