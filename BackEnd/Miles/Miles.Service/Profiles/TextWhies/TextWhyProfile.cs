using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Miles.Core.Entities;
using Miles.Service.Dtos.TextWhies;

namespace Miles.Service.Profiles.TextWhies
{
    public class TextWhyProfile:Profile
    {
        public TextWhyProfile() {
            CreateMap<TextWhyPostDto, TextWhy>();
            CreateMap<TextWhyUpdateDto, TextWhy>();
            CreateMap<TextWhy, TextWhyUpdateDto>();
        }
    }
}
