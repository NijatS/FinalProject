using AutoMapper;
using Miles.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Miles.Core.Entities;
using Miles.Service.Dtos.Sliders;

namespace Miles.Service.Profiles.Sliders
{
    public class SliderProfile:Profile
    {
        public SliderProfile() {
            CreateMap<SliderPostDto, Slider>();
            CreateMap<SliderUpdateDto, Slider>();
            CreateMap<Slider, SliderUpdateDto>();
        }
    }
}
