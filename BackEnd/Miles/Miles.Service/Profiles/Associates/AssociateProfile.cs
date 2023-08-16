using AutoMapper;
using Miles.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Miles.Core.Entities;
using Miles.Service.Dtos.Associates;

namespace Miles.Service.Profiles.Associates
{
    public class AssociateProfile:Profile
    {
        public AssociateProfile() {
            CreateMap<AssociatePostDto, Associate>();
            CreateMap<AssociateUpdateDto, Associate>();
            CreateMap<Associate, AssociateUpdateDto>();
        }
    }
}
