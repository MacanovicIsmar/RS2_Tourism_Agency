using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourismAgency.Services
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {

            CreateMap<Database.Korisnik, RS2_Tourism_Agency.Model.Korisnici>();
            CreateMap<Database.Putovanje, RS2_Tourism_Agency.Model.Putovanje>();
            CreateMap<Database.Grupe, RS2_Tourism_Agency.Model.Grupe>();
            CreateMap<RS2_Tourism_Agency.Model.Request.PutovanjeInsertRequest ,Database.Putovanje>();
            CreateMap<RS2_Tourism_Agency.Model.Request.PutovanjeUpdateRequest, Database.Putovanje>();
            CreateMap<RS2_Tourism_Agency.Model.Request.UpsertKorisnikRequest, Database.Korisnik>();

        }




    }
}
