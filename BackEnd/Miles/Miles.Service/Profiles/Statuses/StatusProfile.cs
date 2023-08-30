using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Miles.Core.Entities;
using Miles.Service.Dtos.Statuses;

namespace Miles.Service.Profiles.Statuses
{
    public class StatusProfile:Profile
    {
        public StatusProfile() {
            CreateMap<StatusPostDto, Status>();
            CreateMap<StatusUpdateDto, Status>();
            CreateMap<Status,StatusUpdateDto>();
        }
    }
}
