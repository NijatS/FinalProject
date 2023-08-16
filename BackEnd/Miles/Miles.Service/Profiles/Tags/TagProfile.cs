using AutoMapper;
using Miles.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Miles.Service.Dtos.Categories;
using Miles.Core.Entities;
using Miles.Service.Dtos.Tags;

namespace Miles.Service.Profiles.Tags
{
    public class TagProfile:Profile
    {
        public TagProfile() {
            CreateMap<TagPostDto, Tag>();
            CreateMap<TagUpdateDto, Tag>();
            CreateMap<Tag,TagUpdateDto>();
        }
    }
}
