using AutoMapper;
using Miles.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Miles.Service.Dtos.Categories;
using Miles.Core.Entities;
using Miles.Service.Dtos.Fuels;

namespace Miles.Service.Profiles.Fuels
{
    public class FuelProfile:Profile
    {
        public FuelProfile() {
            CreateMap<FuelPostDto, Fuel>();
            CreateMap<FuelUpdateDto, Fuel>();
            CreateMap<Fuel,FuelUpdateDto>();
        }
    }
}
