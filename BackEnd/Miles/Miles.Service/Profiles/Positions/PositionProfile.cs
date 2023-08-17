using AutoMapper;
using Miles.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Miles.Service.Dtos.Categories;
using Miles.Core.Entities;
using Miles.Service.Dtos.Positions;

namespace Miles.Service.Profiles.Positions
{
    public class PositionProfile:Profile
    {
        public PositionProfile() {
            CreateMap<PositionPostDto, Position>();
            CreateMap<PositionUpdateDto, Position>();
            CreateMap<Position,PositionUpdateDto>();
        }
    }
}
