using AutoMapper;
using Miles.Core.Entities;
using Miles.Service.Dtos.Subscribes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.Profiles.Subscribes
{
    public class SubscribeProfile:Profile
    {
        public SubscribeProfile()
        {
            CreateMap<SubscribePostDto, Subscribe>();
        }
    }
}
