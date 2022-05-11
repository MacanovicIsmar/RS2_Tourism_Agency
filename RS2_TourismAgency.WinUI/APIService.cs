using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RS2_Tourism_Agency.Model;

namespace RS2_TourismAgency.WinUI
{
    public class APIService
    {
        private string _resource = null;
        public  string  endpoint = "https://localhost:7029/";
        public static string Username = null;
        public static string Password = null;


        public APIService(string resource)
        {


            _resource = resource;
        
        }

        public async Task<T> Get<T>(object search = null)
        {
            var query = "";
            if(search!=null)
            {
                query = await search.ToQueryString();


            }

            var list = await $"{endpoint}{_resource}?{query}"
                .WithBasicAuth(Username,Password)
                .GetJsonAsync<T>();

            return list;
        
        
        }
        public async Task<T> GetById<T>(object Id)
        {
            var result = await $"{endpoint}{_resource}/{Id}"
                .WithBasicAuth(Username, Password)
                .GetJsonAsync<T>();

            return result;


        }
        public async Task<T> Post<T>(object request)
        {
            var result = await $"{endpoint}{_resource}"
                .WithBasicAuth(Username, Password)
                .PostJsonAsync(request).ReceiveJson<T>();

            return result;


        }
        public async Task<T> Put<T>(object Id,object request)
        {
            var result = await $"{endpoint}{_resource}/{Id}"
                .WithBasicAuth(Username, Password)
                .PutJsonAsync(request).ReceiveJson<T>();

            return result;


        }

    }
}
