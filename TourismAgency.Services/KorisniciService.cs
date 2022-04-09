using AutoMapper;
using RS2_Tourism_Agency.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismAgency.Services.Database;

//dodano v2
namespace TourismAgency.Services
{
    //dodano v2
    public class KorisniciService : IKorisniciService
    {

        public Rs2_SeminarskiContext context { get; set;}

        public IMapper Mapper { get; set;}


        public KorisniciService(Rs2_SeminarskiContext context_ ,IMapper mapper_)
        {
            context = context_;
            Mapper = mapper_;
        
        }


        public IEnumerable<Korisnici> Get()
        {

                   
            var result= context.Korisniks.ToList();
            
            return Mapper.Map<List<RS2_Tourism_Agency.Model.Korisnici>>(result);

            //List<Korisnici> list = new List<Korisnici>();

            //foreach (var item in result)
            //{

            //    list.Add(new Korisnici {
            //    Ime=item.Ime,
            //    Prezime=item.Prezime,
            //    Email=item.Email,
            //    Role=item.Role,
            //    Status=item.Status==null?false:item.Status.Value,
            //    Telefon=item.Telefon,
            //    UserName=item.UserName


            //    });


            //}



        }






    }
}
