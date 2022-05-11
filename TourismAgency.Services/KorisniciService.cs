using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RS2_Tourism_Agency.Model;
using RS2_Tourism_Agency.Model.Request;
using RS2_Tourism_Agency.Model.SearchObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TourismAgency.Services.Database;

//dodano v2
namespace TourismAgency.Services
{
    //dodano v2
    public class KorisniciService :
        BASECRUDService
        <
            Korisnici,
            Korisnik,
            KorisniciSearchObject,
            KorisniciInsertRequest,
            KorisnikUpdateRequest
        >,     
        IKorisniciService
    {

        //public Rs2_SeminarskiContext context { get; set;}

        //public IMapper Mapper { get; set;}


        public KorisniciService(Rs2_SeminarskiContext context_ ,IMapper mapper_):base(context_, mapper_)
        {
            //context = context_;
            //Mapper = mapper_;
        
        }


        public override Korisnici Insert(KorisniciInsertRequest Insert)
        {
            //prijasna verzija metode
            var entity = base.Insert(Insert);

            //extended
            foreach (var uloge in Insert.UlogeIdList)
            {

                TourismAgency.Services.Database.KorisniciUloge Korisniciuloge_=
                     new TourismAgency.Services.Database.KorisniciUloge();

                Korisniciuloge_.UlogaId = uloge;
                Korisniciuloge_.KorisnikId = entity.Id;
                Korisniciuloge_.DatumIzmjene = DateTime.Now;
                context.KorisniciUloges.Add(Korisniciuloge_);

            }

            context.SaveChanges();

            return entity;


        }

        public override void BeforeInsert(KorisniciInsertRequest insert, Korisnik entity)
        {

            var salt = GenerateSalt();
            entity.PasswordSalt = salt;
            entity.Password = Generatehash(salt,insert.Password);
            base.BeforeInsert(insert, entity);




        }

        public static string GenerateSalt()
        {
            //RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            //var byteArray = new byte[16];
            //provider.GetBytes(byteArray);


            //return "";
            //var buf = new byte[16];
            //(new RSACryptoServiceProvider()).GetBytes(buf);



            return Convert.ToBase64String(new byte[16]);


        }
        public static string Generatehash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);

           




        }

        public override IQueryable<Korisnik> AddFilter(IQueryable<Korisnik> query, KorisniciSearchObject search = null)
        {
            
            var filterQuery = base.AddFilter(query, search);

            if (!string.IsNullOrWhiteSpace(search?.KorisnickoIme))
            {
                filterQuery=filterQuery.Where(x => x.UserName ==search.KorisnickoIme);


            }
            if (!string.IsNullOrWhiteSpace(search?.NameFTS))
            {
                filterQuery = filterQuery.Where(x => 
                   x.UserName.Contains(search.NameFTS) 
                || x.Ime.Contains(search.NameFTS)
                || x.Prezime.Contains(search.NameFTS)
                );
            }

            return filterQuery;   


        }

        public RS2_Tourism_Agency.Model.Korisnici Login(string username, string password)
        {
            var entity = context.Korisniks
                .Include("KorisniciUloges.Uloga")
                .FirstOrDefault(x=>x.UserName == username);

            if (entity == null)
            {
                return null;                   
            }

            var hash = Generatehash(entity.PasswordSalt, password);

            if (hash != entity.Password)
            {
                return null;
                        
            }


            return Mapper.Map<RS2_Tourism_Agency.Model.Korisnici>(entity);
               
        }
    }
}







//public IEnumerable<Korisnici> Get()
//{


//    var result= context.Korisniks.ToList();

//    return Mapper.Map<List<RS2_Tourism_Agency.Model.Korisnici>>(result);

//    //List<Korisnici> list = new List<Korisnici>();
//    //foreach (var item in result)
//    //{
//    //    list.Add(new Korisnici {
//    //    Ime=item.Ime,
//    //    Prezime=item.Prezime,
//    //    Email=item.Email,
//    //    Role=item.Role,
//    //    Status=item.Status==null?false:item.Status.Value,
//    //    Telefon=item.Telefon,
//    //    UserName=item.UserName
//    //    });
//    //}



//}