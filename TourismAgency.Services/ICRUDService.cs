using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourismAgency.Services
{
    public interface ICRUDService<T,TSearch,TInsert,TUpdate> : Iservice<T,TSearch> 
        where T : class 
        where TSearch : class 
        where TInsert : class 
        where TUpdate : class
    {
        T Insert(TInsert Insert);
        T Update(int Id , TUpdate Update);





    }
}
