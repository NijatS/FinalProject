using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Miles.Core.Entities;
using Miles.Service.Dtos.Cars;

namespace Miles.Service.Profiles.Categories
{
    public class CarProfile:Profile
    {
        public CarProfile() {
            CreateMap<CarPostDto, Car>();
            CreateMap<CarUpdateDto, Car>();
            CreateMap<Car, CarUpdateDto>();
        }
    }
}
