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
            // get model
            CreateMap<Database.Korisnik, RS2_Tourism_Agency.Model.Korisnici>();
            CreateMap<Database.Putovanje, RS2_Tourism_Agency.Model.Putovanje>();
            CreateMap<Database.Grupe, RS2_Tourism_Agency.Model.Grupe>();
            CreateMap<Database.Drzava, RS2_Tourism_Agency.Model.Country>();
            CreateMap<Database.Uloge, RS2_Tourism_Agency.Model.Uloge>();
            CreateMap<Database.KorisniciUloge, RS2_Tourism_Agency.Model.KorisniciUloge>();


            //UPsert maping                   
            CreateMap<RS2_Tourism_Agency.Model.Request.UpsertKorisnikRequest, Database.Korisnik>();
            CreateMap<RS2_Tourism_Agency.Model.Request.DrzavaUpSetRequest, Database.Drzava>();

            //Insert request
            CreateMap<RS2_Tourism_Agency.Model.Request.KorisniciInsertRequest, Database.Korisnik>();
            CreateMap<RS2_Tourism_Agency.Model.Request.PutovanjeInsertRequest, Database.Putovanje>();

            //update request 
            CreateMap<RS2_Tourism_Agency.Model.Request.PutovanjeUpdateRequest, Database.Putovanje>();
            CreateMap<RS2_Tourism_Agency.Model.Request.KorisnikUpdateRequest, Database.Korisnik>();


        }




    }
}
