using AutoMapper;
using RS2_Tourism_Agency.Model;
using RS2_Tourism_Agency.Model.Request;
using RS2_Tourism_Agency.Model.SearchObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismAgency.Services.Database;

namespace TourismAgency.Services
{
    public class DrzavaService:
        BASECRUDService
        <
        Country,
        TourismAgency.Services.Database.Drzava,
        DrzavaSearchObject,
        DrzavaUpSetRequest,
        DrzavaUpSetRequest
        >,
        IDrzavaService
    {
        public DrzavaService(TourismAgency.Services.Database.Rs2_SeminarskiContext context_, IMapper mapper_) : base(context_, mapper_)
        {

            //context = context_;
            //Mapper = mapper_;



        }

        public override IQueryable<Drzava> AddFilter(IQueryable<Drzava> query, DrzavaSearchObject search = null)
        {
            var filterquery = base.AddFilter(query, search);

            if (!string.IsNullOrWhiteSpace(search?.NazivGT))
            {

                filterquery = filterquery.Where(X => X.Naziv.StartsWith(search.NazivGT));
            
            
            }
            return filterquery;

        }






    }
}

//inheriting base crud service 
//using Interface IDrzava 
//needs context and mapper intalized into crud
