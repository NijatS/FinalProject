using AutoMapper;
using Miles.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Miles.Service.Dtos.Categories;
using Miles.Core.Entities;
using Miles.Service.Dtos.UserPricings;

namespace Miles.Service.Profiles.UserPricings
{
    public class UserPricingProfile:Profile
    {
        public UserPricingProfile() {
			CreateMap<UserPricingPostDto, UserPricing>();
            CreateMap<UserPricingUpdateDto, UserPricing>();
            CreateMap<UserPricing,UserPricingUpdateDto>();
        }
    }
}
