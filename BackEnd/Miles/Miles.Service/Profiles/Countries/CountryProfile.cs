using AutoMapper;
using Miles.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Miles.Core.Entities;
using Miles.Service.Dtos.Countries;

namespace Miles.Service.Profiles.Countrys
{
    public class CountryProfile:Profile
    {
        public CountryProfile() {
            CreateMap<CountryPostDto, Country>();
            CreateMap<CountryUpdateDto, Country>();
            CreateMap<Country, CountryUpdateDto>();
        }
    }
}
