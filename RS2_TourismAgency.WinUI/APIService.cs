using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS2_TourismAgency.WinUI
{
    public class APIService
    {
        private string _resource = null;
        public  string  endpoint = "https://localhost:7029/";
        public APIService(string resource)
        {


            _resource = resource;
        
        }

        public async Task<T> Get<T>()
        {
            var list = await $"{endpoint}{_resource}".GetJsonAsync<T>();

            return list;
        
        
        }
        public async Task<T> GetById<T>(object Id)
        {
            var result = await $"{endpoint}{_resource}/{Id}".GetJsonAsync<T>();

            return result;


        }
        public async Task<T> Post<T>(object request)
        {
            var result = await $"{endpoint}{_resource}".PostJsonAsync(request).ReceiveJson<T>();

            return result;


        }
        public async Task<T> Put<T>(object Id,object request)
        {
            var result = await $"{endpoint}{_resource}/{Id}".PutJsonAsync(request).ReceiveJson<T>();

            return result;


        }

    }
}
