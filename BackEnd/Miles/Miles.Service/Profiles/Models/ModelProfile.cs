using AutoMapper;
using Miles.Core.Entities;
using Miles.Service.Dtos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.Profiles.Models
{
    public class ModelProfile:Profile
    {
        public ModelProfile()
        {
            CreateMap<ModelPostDto, Model>();
            CreateMap<ModelUpdateDto, Model>();
            CreateMap<Model, ModelUpdateDto>();
        }
    }
}
