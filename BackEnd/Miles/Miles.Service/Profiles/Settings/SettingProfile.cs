using AutoMapper;
using Miles.Core.Entities;
using Miles.Service.Dtos.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.Profiles.Settings
{
    public class SettingProfile:Profile
    {
        public SettingProfile()
        {
            CreateMap<SettingPostDto, Setting>();
            CreateMap<SettingUpdateDto, Setting>();
            CreateMap<Setting, SettingUpdateDto>();
        }
    }
}
