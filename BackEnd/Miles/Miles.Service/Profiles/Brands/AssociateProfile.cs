using AutoMapper;
using Miles.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Miles.Core.Entities;
using Miles.Service.Dtos.Brands;

namespace Miles.Service.Profiles.Brands
{
    public class BrandProfile:Profile
    {
        public BrandProfile() {
            CreateMap<BrandPostDto, Brand>();
            CreateMap<BrandUpdateDto, Brand>();
            CreateMap<Brand, BrandUpdateDto>();
        }
    }
}
