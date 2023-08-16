using AutoMapper;
using Miles.Core.Entities;
using Miles.Service.Dtos.Blogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.Profiles.Blogs
{
    public class BlogProfile:Profile
    {
        public BlogProfile()
        {
            CreateMap<BlogPostDto, Blog>();
            CreateMap<BlogUpdateDto, Blog>();
            CreateMap<Blog, BlogUpdateDto>();
        }
    }
}
