using AutoMapper;
using Miles.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Miles.Service.Dtos.Categories;
using Miles.Core.Entities;
using Miles.Service.Dtos.Colors;

namespace Miles.Service.Profiles.Colors
{
    public class ColorProfile:Profile
    {
        public ColorProfile() {
            CreateMap<ColorPostDto, Color>();
            CreateMap<ColorUpdateDto, Color>();
            CreateMap<Color,ColorUpdateDto>();
        }
    }
}
