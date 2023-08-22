using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Miles.Core.Entities;
using Miles.Service.Dtos.Bans;

namespace Miles.Service.Profiles.Bans
{
    public class BanProfile:Profile
    {
        public BanProfile() {
            CreateMap<BanPostDto, Ban>();
            CreateMap<BanUpdateDto, Ban>();
            CreateMap<Ban,BanUpdateDto>();
        }
    }
}
