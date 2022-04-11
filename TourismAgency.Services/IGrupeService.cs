﻿using RS2_Tourism_Agency.Model;
using RS2_Tourism_Agency.Model.SearchObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourismAgency.Services
{
    public interface IGrupeService:Iservice<Grupe,GrupeSearchObject>
    {
        //IEnumerable<Grupe> Get();

        //Grupe GetbyId(int id);
    }
}
