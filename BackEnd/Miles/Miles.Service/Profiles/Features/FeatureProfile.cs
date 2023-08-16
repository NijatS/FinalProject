using AutoMapper;
using Miles.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Miles.Core.Entities;
using Miles.Service.Dtos.Features;

namespace Miles.Service.Profiles.Features
{
    public class FeatureProfile:Profile
    {
        public FeatureProfile() {
            CreateMap<FeaturePostDto, Feature>();
            CreateMap<FeatureUpdateDto, Feature>();
            CreateMap<Feature, FeatureUpdateDto>();
        }
    }
}
