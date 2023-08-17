using AutoMapper;
using Miles.Core.Entities;
using Miles.Service.Dtos.Staffs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.Profiles.Staffs
{
    public class StaffProfile:Profile
    {
        public StaffProfile()
        {
            CreateMap<StaffPostDto, Staff>();
            CreateMap<StaffUpdateDto, Staff>();
            CreateMap<Staff, StaffUpdateDto>();
        }
    }
}
