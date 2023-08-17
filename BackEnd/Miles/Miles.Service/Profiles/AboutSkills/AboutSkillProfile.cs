using AutoMapper;
using Miles.Core.Entities;
using Miles.Service.Dtos.AboutSkills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.Profiles.AboutSkills
{
    public class AboutSkillProfile:Profile
    {
        public AboutSkillProfile()
        {
            CreateMap<AboutSkillPostDto, AboutSkill>();
            CreateMap<AboutSkillUpdateDto, AboutSkill>();
            CreateMap<AboutSkill, AboutSkillUpdateDto>();
        }
    }
}
